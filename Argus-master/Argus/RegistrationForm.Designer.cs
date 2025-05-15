namespace Argus
{
    partial class RegistrationForm
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
            this.btn_register = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_region = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_contactno = new System.Windows.Forms.TextBox();
            this.txt_passconfirm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_register.Location = new System.Drawing.Point(1087, 457);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(209, 60);
            this.btn_register.TabIndex = 25;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(774, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 37);
            this.label11.TabIndex = 37;
            this.label11.Text = "REGION:";
            // 
            // cmb_city
            // 
            this.cmb_city.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_city.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(863, 108);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(417, 40);
            this.cmb_city.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "FIRST NAME:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmb_region
            // 
            this.cmb_region.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_region.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cmb_region.FormattingEnabled = true;
            this.cmb_region.Items.AddRange(new object[] {
            "Region I – Ilocos Region",
            "Region II – Cagayan Valley",
            "Region III – Central Luzon",
            "Region IV‑A – CALABARZON",
            "MIMAROPA Region",
            "Region V – Bicol Region",
            "Region VI – Western Visayas",
            "Region VII – Central Visayas",
            "Region VIII – Eastern Visayas",
            "Region IX – Zamboanga Peninsula",
            "Region X – Northern Mindanao",
            "Region XI – Davao Region",
            "Region XII – SOCCSKSARGEN",
            "Region XIII – Caraga",
            "NCR – National Capital Region",
            "CAR – Cordillera Administrative Region",
            "BARMM – Bangsamoro Autonomous Region in Muslim Mindanao"});
            this.cmb_region.Location = new System.Drawing.Point(905, 33);
            this.cmb_region.Name = "cmb_region";
            this.cmb_region.Size = new System.Drawing.Size(375, 40);
            this.cmb_region.TabIndex = 39;
            this.cmb_region.SelectedIndexChanged += new System.EventHandler(this.cmb_region_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "LAST NAME:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.BackColor = System.Drawing.SystemColors.Control;
            this.txt_lname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(202, 104);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(496, 39);
            this.txt_lname.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(774, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 37);
            this.label10.TabIndex = 38;
            this.label10.Text = "CITY:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Control;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(125, 177);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(573, 39);
            this.txt_email.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "EMAIL:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_fname
            // 
            this.txt_fname.BackColor = System.Drawing.SystemColors.Control;
            this.txt_fname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(202, 37);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(496, 39);
            this.txt_fname.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 37);
            this.label6.TabIndex = 26;
            this.label6.Text = "CONTACT NO:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_contactno
            // 
            this.txt_contactno.BackColor = System.Drawing.SystemColors.Control;
            this.txt_contactno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contactno.Location = new System.Drawing.Point(224, 244);
            this.txt_contactno.Name = "txt_contactno";
            this.txt_contactno.Size = new System.Drawing.Size(474, 39);
            this.txt_contactno.TabIndex = 33;
            // 
            // txt_passconfirm
            // 
            this.txt_passconfirm.BackColor = System.Drawing.SystemColors.Control;
            this.txt_passconfirm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passconfirm.Location = new System.Drawing.Point(324, 461);
            this.txt_passconfirm.Name = "txt_passconfirm";
            this.txt_passconfirm.Size = new System.Drawing.Size(374, 39);
            this.txt_passconfirm.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 37);
            this.label9.TabIndex = 29;
            this.label9.Text = "CONFIRM PASSWORD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 37);
            this.label7.TabIndex = 27;
            this.label7.Text = "TELEPHONE:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.btn_register);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cmb_city);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmb_region);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_lname);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_fname);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_contactno);
            this.panel3.Controls.Add(this.txt_passconfirm);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_telephone);
            this.panel3.Controls.Add(this.txt_pass);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(21, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1308, 520);
            this.panel3.TabIndex = 26;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txt_telephone
            // 
            this.txt_telephone.BackColor = System.Drawing.SystemColors.Control;
            this.txt_telephone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telephone.Location = new System.Drawing.Point(195, 323);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(496, 39);
            this.txt_telephone.TabIndex = 34;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Control;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(202, 388);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(496, 39);
            this.txt_pass.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 37);
            this.label8.TabIndex = 28;
            this.label8.Text = "PASSWORD:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(416, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 54);
            this.label2.TabIndex = 24;
            this.label2.Text = "USER REGISTRATION FORM";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_back.Location = new System.Drawing.Point(781, 461);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 44);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_region;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_contactno;
        private System.Windows.Forms.TextBox txt_passconfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
    }
}