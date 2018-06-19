using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_O
{
    public partial class AIGameForm : Form
    {

        #region Load

        private ShapeContainer shapeContainer = new ShapeContainer();
        private OvalShape os = new OvalShape();
        private Point ospoint;
        private int LeaveInt = 0;
        private SpherePoint lslist = new SpherePoint() { Direction = "Left", FPoint = new Point(0, 0) };

        public AIGameForm()
        {
            InitializeComponent();
        }

        private void ControlPen()
        {
            this.SuspendLayout();
            this.shapeContainer.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.os});
            this.shapeContainer.Size = new System.Drawing.Size(674, 365);
            this.shapeContainer.TabIndex = 0;
            this.shapeContainer.TabStop = false;
            this.Controls.Add(this.shapeContainer);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            ControlPen();
            os.Location = new Point(0, 0);
            os.Size = new Size(50, 50);
            os.FillStyle = FillStyle.Divot;
            ospoint = os.Location;
            pnl.Controls.Add(shapeContainer);
            RandomRs();
            judge();
        }

        #endregion

        private string AISwitch()
        {
            if (os.Location.X > rs.Location.X)
                return "Left";
            else if (os.Location.X == rs.Location.X)
            {
                if (os.Location.Y > rs.Location.Y)
                    return "Up";
                else
                {
                    return "Down";
                }
            }
            else
                return "Right";
        }

        #region Key

        private void judge()
        {
            switch (AISwitch())
            {
                case "Up": osLocationy(-10); break;
                case "Down": osLocationy(10); break;
                case "Left": osLocationx(-10); break;
                case "Right": osLocationx(10); break;
            }
            if (os.Location.X < 0)
                osLocationx(10);
            if (os.Location.X > 500)
                osLocationx(-10);
            if (os.Location.Y < 0)
                osLocationy(10);
            if (os.Location.Y > 500)
                osLocationy(-10);
            lslist.FPoint = os.Location;
        }

        public void osLocation(int X, int Y) { os.Location = new Point(X, Y); ospoint = os.Location; }
        public void osLocationx(int X) { os.Location = new Point(ospoint.X + X, ospoint.Y); ospoint = os.Location; }
        public void osLocationy(int Y) { os.Location = new Point(ospoint.X, ospoint.Y + Y); ospoint = os.Location; }

        #endregion

        #region 跳关

        private void pnl_Paint(object sender, PaintEventArgs e)
        {
            tooltxt.Text = ospoint.X.ToString() + "-" + ospoint.Y.ToString() + "^" + rs.Location.X.ToString() + "-" + rs.Location.Y.ToString();
            if (ospoint == rs.Location)
                RandomRs();
        }

        private void RandomRs()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    osPointClass.pointx[i, j] = new Point(j * 50, i * 50);
                }
            }
            Random r = new Random();
            rs.Location = osPointClass.pointx[r.Next(0, 11), r.Next(0, 11)];
            LeaveInt += 1;
            LeaveTxt.Text = LeaveTxt.Text.Substring(0, 6) + LeaveInt.ToString();
        }

        #endregion

        private void toolStripMenuItemNum_Click(object sender, EventArgs e) { Tim_Ai.Interval = int.Parse(((ToolStripItem)sender).Text); }

        private void Tim_Ai_Tick(object sender, EventArgs e) { judge(); }

        private void Tim_time_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = "NowDateTime:" + DateTime.Now.ToString() + "." + DateTime.Now.Millisecond;
        }

    }
}
