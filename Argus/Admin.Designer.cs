namespace Argus
{
    partial class Admin
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
            this.header = new System.Windows.Forms.Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register_acc = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.header.Controls.Add(this.lbl_username);
            this.header.Controls.Add(this.label1);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1352, 80);
            this.header.TabIndex = 8;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(166, 28);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(119, 32);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Renatha Signature", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Argus";
            // 
            // btn_register_acc
            // 
            this.btn_register_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register_acc.Location = new System.Drawing.Point(0, 86);
            this.btn_register_acc.Name = "btn_register_acc";
            this.btn_register_acc.Size = new System.Drawing.Size(204, 50);
            this.btn_register_acc.TabIndex = 9;
            this.btn_register_acc.Text = "REGISTER ACC";
            this.btn_register_acc.UseVisualStyleBackColor = true;
            this.btn_register_acc.Click += new System.EventHandler(this.btn_register_acc_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_register_acc);
            this.Controls.Add(this.header);
            this.Name = "Admin";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_register_acc;
    }
}

