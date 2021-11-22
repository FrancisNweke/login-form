namespace LoginForm
{
    partial class CouponGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CouponGenerator));
            this.lblCoupon = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.couponGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetClientKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listAllUserControl1 = new LoginForm.ListAllUserControl();
            this.newUserControl1 = new LoginForm.NewUserControl();
            this.resetClientKeyUserControl1 = new LoginForm.ResetClientKeyUserControl();
            this.couponGeneratorControlForm1 = new LoginForm.CouponGeneratorControlForm();
            this.passwordReset1 = new LoginForm.PasswordReset();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoupon
            // 
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoupon.Location = new System.Drawing.Point(97, 54);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Size = new System.Drawing.Size(0, 14);
            this.lblCoupon.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDate.Location = new System.Drawing.Point(3, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 15);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "DateTime";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCurrentUser.Location = new System.Drawing.Point(699, 17);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(69, 17);
            this.lblCurrentUser.TabIndex = 8;
            this.lblCurrentUser.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 41);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(791, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 401);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Copyright © 2020 Asix Limited.\r\nAll Rights Reserved.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couponGeneratorToolStripMenuItem,
            this.accountSettingToolStripMenuItem,
            this.createNewUserToolStripMenuItem,
            this.viewAllUsersToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(194, 87);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // couponGeneratorToolStripMenuItem
            // 
            this.couponGeneratorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couponGeneratorToolStripMenuItem.Image")));
            this.couponGeneratorToolStripMenuItem.Name = "couponGeneratorToolStripMenuItem";
            this.couponGeneratorToolStripMenuItem.Size = new System.Drawing.Size(187, 21);
            this.couponGeneratorToolStripMenuItem.Text = "Coupon Generator";
            this.couponGeneratorToolStripMenuItem.Click += new System.EventHandler(this.couponGeneratorToolStripMenuItem_Click);
            // 
            // accountSettingToolStripMenuItem
            // 
            this.accountSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetPasswordToolStripMenuItem,
            this.resetClientKeyToolStripMenuItem});
            this.accountSettingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountSettingToolStripMenuItem.Image")));
            this.accountSettingToolStripMenuItem.Name = "accountSettingToolStripMenuItem";
            this.accountSettingToolStripMenuItem.Size = new System.Drawing.Size(187, 20);
            this.accountSettingToolStripMenuItem.Text = "Account Setting";
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetPasswordToolStripMenuItem.Image")));
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // resetClientKeyToolStripMenuItem
            // 
            this.resetClientKeyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetClientKeyToolStripMenuItem.Image")));
            this.resetClientKeyToolStripMenuItem.Name = "resetClientKeyToolStripMenuItem";
            this.resetClientKeyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.resetClientKeyToolStripMenuItem.Text = "Reset Client Key";
            this.resetClientKeyToolStripMenuItem.Click += new System.EventHandler(this.resetClientKeyToolStripMenuItem_Click);
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewUserToolStripMenuItem.Image")));
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(187, 20);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            this.createNewUserToolStripMenuItem.Click += new System.EventHandler(this.createNewUserToolStripMenuItem_Click);
            // 
            // viewAllUsersToolStripMenuItem
            // 
            this.viewAllUsersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAllUsersToolStripMenuItem.Image")));
            this.viewAllUsersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewAllUsersToolStripMenuItem.Name = "viewAllUsersToolStripMenuItem";
            this.viewAllUsersToolStripMenuItem.Size = new System.Drawing.Size(187, 20);
            this.viewAllUsersToolStripMenuItem.Text = "View All Users";
            this.viewAllUsersToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.viewAllUsersToolStripMenuItem.Click += new System.EventHandler(this.viewAllUsersToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listAllUserControl1
            // 
            this.listAllUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listAllUserControl1.BackgroundImage")));
            this.listAllUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listAllUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAllUserControl1.Location = new System.Drawing.Point(194, 41);
            this.listAllUserControl1.Name = "listAllUserControl1";
            this.listAllUserControl1.Size = new System.Drawing.Size(705, 401);
            this.listAllUserControl1.TabIndex = 17;
            // 
            // newUserControl1
            // 
            this.newUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newUserControl1.BackgroundImage")));
            this.newUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newUserControl1.Location = new System.Drawing.Point(200, 47);
            this.newUserControl1.Name = "newUserControl1";
            this.newUserControl1.Size = new System.Drawing.Size(699, 395);
            this.newUserControl1.TabIndex = 16;
            // 
            // resetClientKeyUserControl1
            // 
            this.resetClientKeyUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetClientKeyUserControl1.BackgroundImage")));
            this.resetClientKeyUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetClientKeyUserControl1.Location = new System.Drawing.Point(200, 44);
            this.resetClientKeyUserControl1.Name = "resetClientKeyUserControl1";
            this.resetClientKeyUserControl1.Size = new System.Drawing.Size(699, 395);
            this.resetClientKeyUserControl1.TabIndex = 15;
            // 
            // couponGeneratorControlForm1
            // 
            this.couponGeneratorControlForm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("couponGeneratorControlForm1.BackgroundImage")));
            this.couponGeneratorControlForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.couponGeneratorControlForm1.Location = new System.Drawing.Point(200, 44);
            this.couponGeneratorControlForm1.Name = "couponGeneratorControlForm1";
            this.couponGeneratorControlForm1.Size = new System.Drawing.Size(699, 395);
            this.couponGeneratorControlForm1.TabIndex = 14;
            this.couponGeneratorControlForm1.Load += new System.EventHandler(this.couponGeneratorControlForm1_Load);
            // 
            // passwordReset1
            // 
            this.passwordReset1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordReset1.BackgroundImage")));
            this.passwordReset1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordReset1.Location = new System.Drawing.Point(200, 44);
            this.passwordReset1.Name = "passwordReset1";
            this.passwordReset1.Size = new System.Drawing.Size(699, 395);
            this.passwordReset1.TabIndex = 13;
            // 
            // CouponGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 442);
            this.ControlBox = false;
            this.Controls.Add(this.listAllUserControl1);
            this.Controls.Add(this.newUserControl1);
            this.Controls.Add(this.resetClientKeyUserControl1);
            this.Controls.Add(this.couponGeneratorControlForm1);
            this.Controls.Add(this.passwordReset1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCoupon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CouponGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CouponGenerator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCoupon;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetClientKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem couponGeneratorToolStripMenuItem;
        private PasswordReset passwordReset1;
        private CouponGeneratorControlForm couponGeneratorControlForm1;
        private ResetClientKeyUserControl resetClientKeyUserControl1;
        private NewUserControl newUserControl1;
        private System.Windows.Forms.ToolStripMenuItem viewAllUsersToolStripMenuItem;
        private ListAllUserControl listAllUserControl1;
        private System.Windows.Forms.Timer timer1;
    }
}