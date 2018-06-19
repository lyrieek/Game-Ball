namespace Game_O
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.购买外挂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.亲输入密码吧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btn_购买 = new System.Windows.Forms.ToolStripTextBox();
            this.游戏说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.方向键控制移动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a键跳关卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于天浩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qQ2361832278ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phone15652867784ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.关机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LeaveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl = new System.Windows.Forms.Panel();
            this.sj = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rs = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tim_leave = new System.Windows.Forms.Timer(this.components);
            this.Tim_admin = new System.Windows.Forms.Timer(this.components);
            this.Tim_Lca = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.tooltxt,
            this.toolStripStatusLabel1,
            this.LeaveTxt,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(555, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.购买外挂ToolStripMenuItem,
            this.游戏说明ToolStripMenuItem,
            this.关于天浩ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.关机ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(72, 21);
            this.toolStripSplitButton1.Text = "开始菜单";
            // 
            // 购买外挂ToolStripMenuItem
            // 
            this.购买外挂ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.亲输入密码吧ToolStripMenuItem,
            this.toolStripTextBox1,
            this.btn_购买});
            this.购买外挂ToolStripMenuItem.Name = "购买外挂ToolStripMenuItem";
            this.购买外挂ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.购买外挂ToolStripMenuItem.Text = "购买外挂";
            // 
            // 亲输入密码吧ToolStripMenuItem
            // 
            this.亲输入密码吧ToolStripMenuItem.Name = "亲输入密码吧ToolStripMenuItem";
            this.亲输入密码吧ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.亲输入密码吧ToolStripMenuItem.Text = "亲，输入注册码吧";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // btn_购买
            // 
            this.btn_购买.Name = "btn_购买";
            this.btn_购买.ReadOnly = true;
            this.btn_购买.Size = new System.Drawing.Size(100, 23);
            this.btn_购买.Text = "购买";
            this.btn_购买.ToolTipText = "单击确认";
            this.btn_购买.Click += new System.EventHandler(this.btn_购买_Click);
            // 
            // 游戏说明ToolStripMenuItem
            // 
            this.游戏说明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.方向键控制移动ToolStripMenuItem,
            this.a键跳关卡ToolStripMenuItem});
            this.游戏说明ToolStripMenuItem.Name = "游戏说明ToolStripMenuItem";
            this.游戏说明ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.游戏说明ToolStripMenuItem.Text = "游戏说明";
            // 
            // 方向键控制移动ToolStripMenuItem
            // 
            this.方向键控制移动ToolStripMenuItem.Name = "方向键控制移动ToolStripMenuItem";
            this.方向键控制移动ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.方向键控制移动ToolStripMenuItem.Text = "方向键控制移动";
            // 
            // a键跳关卡ToolStripMenuItem
            // 
            this.a键跳关卡ToolStripMenuItem.Name = "a键跳关卡ToolStripMenuItem";
            this.a键跳关卡ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.a键跳关卡ToolStripMenuItem.Text = "A键跳关卡";
            // 
            // 关于天浩ToolStripMenuItem
            // 
            this.关于天浩ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qQ2361832278ToolStripMenuItem,
            this.phone15652867784ToolStripMenuItem});
            this.关于天浩ToolStripMenuItem.Name = "关于天浩ToolStripMenuItem";
            this.关于天浩ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于天浩ToolStripMenuItem.Text = "关于天浩";
            // 
            // qQ2361832278ToolStripMenuItem
            // 
            this.qQ2361832278ToolStripMenuItem.Name = "qQ2361832278ToolStripMenuItem";
            this.qQ2361832278ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.qQ2361832278ToolStripMenuItem.Text = "QQ:2361832278";
            // 
            // phone15652867784ToolStripMenuItem
            // 
            this.phone15652867784ToolStripMenuItem.Name = "phone15652867784ToolStripMenuItem";
            this.phone15652867784ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.phone15652867784ToolStripMenuItem.Text = "Phone:15652867784";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // 关机ToolStripMenuItem
            // 
            this.关机ToolStripMenuItem.Name = "关机ToolStripMenuItem";
            this.关机ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关机ToolStripMenuItem.Text = "关机";
            this.关机ToolStripMenuItem.Click += new System.EventHandler(this.关机ToolStripMenuItem_Click);
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
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(132, 18);
            this.toolStripStatusLabel3.Text = "还剩下120S结束试用期";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl.Controls.Add(this.sj);
            this.pnl.Controls.Add(this.shapeContainer1);
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(555, 555);
            this.pnl.TabIndex = 1;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // sj
            // 
            this.sj.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sj.Location = new System.Drawing.Point(135, 198);
            this.sj.Name = "sj";
            this.sj.Size = new System.Drawing.Size(259, 127);
            this.sj.TabIndex = 1;
            this.sj.Text = "开始游戏";
            this.sj.UseVisualStyleBackColor = true;
            this.sj.VisibleChanged += new System.EventHandler(this.sj_VisibleChanged);
            this.sj.Click += new System.EventHandler(this.sj_Click);
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
            // tim_leave
            // 
            this.tim_leave.Enabled = true;
            this.tim_leave.Interval = 1200;
            this.tim_leave.Tick += new System.EventHandler(this.tim_leave_Tick);
            // 
            // Tim_admin
            // 
            this.Tim_admin.Enabled = true;
            this.Tim_admin.Interval = 1000;
            this.Tim_admin.Tick += new System.EventHandler(this.tim_admin_Tick);
            // 
            // Tim_Lca
            // 
            this.Tim_Lca.Interval = 250;
            this.Tim_Lca.Tick += new System.EventHandler(this.Tim_Lca_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 576);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnl);
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天浩——Game_O";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameForm_PreviewKeyDown);
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
        private System.Windows.Forms.Timer tim_leave;
        private System.Windows.Forms.Button sj;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 关于天浩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 游戏说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qQ2361832278ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phone15652867784ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 购买外挂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 亲输入密码吧ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox btn_购买;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer Tim_admin;
        private System.Windows.Forms.ToolStripMenuItem 方向键控制移动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem a键跳关卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关机ToolStripMenuItem;
        private System.Windows.Forms.Timer Tim_Lca;



    }
}

