namespace Game_O
{
    partial class AIGameForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIGameForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tooltxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LeaveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rs = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Tim_Ai = new System.Windows.Forms.Timer(this.components);
            this.Tim_time = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltxt,
            this.toolStripStatusLabel1,
            this.LeaveTxt,
            this.toolStripStatusLabel2,
            this.toolStripSplitButton1,
            this.lbl_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(555, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tooltxt
            // 
            this.tooltxt.Name = "tooltxt";
            this.tooltxt.Size = new System.Drawing.Size(41, 18);
            this.tooltxt.Text = "00-00";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 18);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // LeaveTxt
            // 
            this.LeaveTxt.Name = "LeaveTxt";
            this.LeaveTxt.Size = new System.Drawing.Size(44, 18);
            this.LeaveTxt.Text = "Leave:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 18);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem11,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.toolStripMenuItem9,
            this.toolStripMenuItem1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(48, 21);
            this.toolStripSplitButton1.Text = "速度";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem12.Text = "25";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItemNum_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem11.Text = "70";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItemNum_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem7.Text = "200";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItemNum_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem6.Text = "500";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItemNum_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem5.Text = "700";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItemNum_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem9.Text = "1000";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItemNum_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem1.Text = "2500";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItemNum_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(129, 18);
            this.lbl_time.Text = "NowDateTime:--:--:--";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl.Controls.Add(this.shapeContainer1);
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(555, 555);
            this.pnl.TabIndex = 1;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rs});
            this.shapeContainer1.Size = new System.Drawing.Size(551, 551);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rs
            // 
            this.rs.BackColor = System.Drawing.Color.Lime;
            this.rs.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rs.Location = new System.Drawing.Point(0, 0);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(50, 50);
            // 
            // Tim_Ai
            // 
            this.Tim_Ai.Enabled = true;
            this.Tim_Ai.Interval = 12;
            this.Tim_Ai.Tick += new System.EventHandler(this.Tim_Ai_Tick);
            // 
            // Tim_time
            // 
            this.Tim_time.Enabled = true;
            this.Tim_time.Interval = 12;
            this.Tim_time.Tick += new System.EventHandler(this.Tim_time_Tick);
            // 
            // AIGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 576);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnl);
            this.KeyPreview = true;
            this.Name = "AIGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI版";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tooltxt;
        private System.Windows.Forms.Panel pnl;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LeaveTxt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer Tim_Ai;
        private System.Windows.Forms.ToolStripStatusLabel lbl_time;
        private System.Windows.Forms.Timer Tim_time;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;



    }
}

