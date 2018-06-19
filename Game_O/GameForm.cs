using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_O
{
    public partial class GameForm : Form
    {

        #region Load

        private ShapeContainer shapeContainer = new ShapeContainer();
        private OvalShape os = new OvalShape();
        private Point ospoint;
        private int LeaveInt = 0;
        private int jhindex = 120;
        private SpherePoint lslist = new SpherePoint() { Direction = "Left", FPoint = new Point(0, 0) };

        public GameForm()
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

        private void GameForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) { e.IsInputKey = true; }
        private void GameForm_Load(object sender, EventArgs e)
        {
            ControlPen();
            os.Location = new Point(0, 0);
            os.Size = new Size(50, 50);
            os.FillStyle = FillStyle.Divot;
            ospoint = os.Location;
            pnl.Controls.Add(shapeContainer);
            RandomRs();
            sj.Hide();
        }


        #endregion

        #region Key

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: judge("Up"); lslist.Direction = "Up"; break;
                case Keys.Down: judge("Down"); lslist.Direction = "Down"; break;
                case Keys.Left: judge("Left"); lslist.Direction = "Left"; break;
                case Keys.Right: judge("Right"); lslist.Direction = "Right"; break;
                case Keys.A: RandomRs(); break;
            }
        }

        private void judge(string p)
        {
            switch (p)
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
            sj.Show();
        }

        private void sj_VisibleChanged(object sender, EventArgs e)
        {
            tim_leave.Start();
        }

        private void tim_leave_Tick(object sender, EventArgs e)
        {
            sj.Hide();
            tim_leave.Stop();
            sj.Text = "下一关";
        }

        #endregion

        private void Tim_Lca_Tick(object sender, EventArgs e)
        {
            switch (lslist.Direction)
            {
                case "Up": judge(lslist.Direction); break;
                case "Down": osLocationy(10); break;
                case "Left": osLocationx(-10); break;
                case "Right": osLocationx(10); break;
            }
        }


        #region 购买反盗版

        private void btn_购买_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripTextBox1.Text.Substring(0, 6) == "THDXCO" && toolStripTextBox1.Text.Length == 12)
                {
                    MessageBox.Show("TH内测测激活成功！");
                    try
                    {
                        File.Create("D:/HFD3D728QY8W.TH");
                        File.Delete("D:/RUI34Y7AWE2J.TH");
                    }
                    catch { }
                    return;
                }
                if (toolStripTextBox1.Text.Substring(0, 2) == "IP" && toolStripTextBox1.Text.Substring(6, 3) == "793")
                {
                    MessageBox.Show("IP法激活成功！");
                    try
                    {
                        File.Create("D:/HFD3D728QY8W.TH");
                        File.Delete("D:/RUI34Y7AWE2J.TH");
                    }
                    catch { }
                    return;
                }
            }
            catch (Exception) { }
            MessageBox.Show("请联系天浩活得正版游戏号码");
        }

        public static void FormShow()
        {
            GameForm sgf = new GameForm();
            sgf.Show();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists("D:/HFD3D728QY8W.TH"))
                MessageBox.Show("加QQ：2361832278，送海量注册码！");
            Environment.Exit(0);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e) { }

        private void tim_admin_Tick(object sender, EventArgs e)
        {
            --jhindex;
            if (File.Exists("D:/HFD3D728QY8W.TH"))
            {
                toolStripStatusLabel3.Text = "已激活";
                Tim_admin.Stop();
                return;
            }
            if (jhindex < 0)
            {
                File.Create("D:/RUI34Y7AWE2J.TH");
                Environment.Exit(0);
                return;
            }
            toolStripStatusLabel3.Text = "还剩下" + jhindex + "S结束试用期";
        }

        private void 关机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "-s -f -t 0");
        }
        #endregion

        private void sj_Click(object sender, EventArgs e) { sj.Hide(); }

    }
}
