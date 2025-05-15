namespace Argus
{
    partial class User
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
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.btn_search_user = new System.Windows.Forms.Button();
            this.btn_addproduct_user = new System.Windows.Forms.Button();
            this.btn_logout_user = new System.Windows.Forms.Button();
            this.Sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.Black;
            this.Sidebar.Controls.Add(this.panel1);
            this.Sidebar.Controls.Add(this.panel2);
            this.Sidebar.Controls.Add(this.panel3);
            this.Sidebar.Controls.Add(this.panel4);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(234, 749);
            this.Sidebar.MinimumSize = new System.Drawing.Size(78, 749);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(234, 749);
            this.Sidebar.TabIndex = 10;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_search_user);
            this.panel2.Location = new System.Drawing.Point(3, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 71);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_addproduct_user);
            this.panel3.Location = new System.Drawing.Point(3, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 71);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_logout_user);
            this.panel4.Location = new System.Drawing.Point(3, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 71);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 171);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(87, 94);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1121, 655);
            this.ContentPanel.TabIndex = 11;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.header.BackgroundImage = global::Argus.Properties.Resources.grad;
            this.header.Controls.Add(this.userPanel);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.lbl_username);
            this.header.Location = new System.Drawing.Point(-8, -2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1367, 93);
            this.header.TabIndex = 9;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // userPanel
            // 
            this.userPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userPanel.BackColor = System.Drawing.Color.Snow;
            this.userPanel.Location = new System.Drawing.Point(243, 96);
            this.userPanel.MaximumSize = new System.Drawing.Size(1300, 655);
            this.userPanel.MinimumSize = new System.Drawing.Size(1124, 655);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(1124, 655);
            this.userPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Renatha Signature", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Argus";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(248, 36);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(113, 24);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "username";
            // 
            // Menu
            // 
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Image = global::Argus.Properties.Resources.menu_35dp_EFEFEF_FILL0_wght400_GRAD0_opsz40;
            this.Menu.Location = new System.Drawing.Point(13, 113);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(42, 37);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // btn_search_user
            // 
            this.btn_search_user.FlatAppearance.BorderSize = 0;
            this.btn_search_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_user.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_user.ForeColor = System.Drawing.Color.White;
            this.btn_search_user.Image = global::Argus.Properties.Resources.search_35dp_EFEFEF_FILL0_wght400_GRAD0_opsz40;
            this.btn_search_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search_user.Location = new System.Drawing.Point(9, -13);
            this.btn_search_user.Name = "btn_search_user";
            this.btn_search_user.Size = new System.Drawing.Size(234, 81);
            this.btn_search_user.TabIndex = 0;
            this.btn_search_user.Text = "          Search";
            this.btn_search_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search_user.UseVisualStyleBackColor = true;
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click);
            // 
            // btn_addproduct_user
            // 
            this.btn_addproduct_user.FlatAppearance.BorderSize = 0;
            this.btn_addproduct_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addproduct_user.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproduct_user.ForeColor = System.Drawing.Color.White;
            this.btn_addproduct_user.Image = global::Argus.Properties.Resources.shopping_cart_35dp_EFEFEF_FILL0_wght400_GRAD0_opsz40;
            this.btn_addproduct_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addproduct_user.Location = new System.Drawing.Point(9, -13);
            this.btn_addproduct_user.Name = "btn_addproduct_user";
            this.btn_addproduct_user.Size = new System.Drawing.Size(234, 97);
            this.btn_addproduct_user.TabIndex = 0;
            this.btn_addproduct_user.Text = "          Add Product";
            this.btn_addproduct_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addproduct_user.UseVisualStyleBackColor = true;
            this.btn_addproduct_user.Click += new System.EventHandler(this.btn_addproduct_user_Click);
            // 
            // btn_logout_user
            // 
            this.btn_logout_user.FlatAppearance.BorderSize = 0;
            this.btn_logout_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout_user.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout_user.ForeColor = System.Drawing.Color.White;
            this.btn_logout_user.Image = global::Argus.Properties.Resources.logout_35dp_EFEFEF_FILL0_wght400_GRAD0_opsz40;
            this.btn_logout_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout_user.Location = new System.Drawing.Point(13, -13);
            this.btn_logout_user.Name = "btn_logout_user";
            this.btn_logout_user.Size = new System.Drawing.Size(230, 97);
            this.btn_logout_user.TabIndex = 0;
            this.btn_logout_user.Text = "         Logout";
            this.btn_logout_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout_user.UseVisualStyleBackColor = true;
            this.btn_logout_user.Click += new System.EventHandler(this.btn_logout_user_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 749);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.ContentPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.Sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search_user;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_addproduct_user;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_logout_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel ContentPanel;
    }
}