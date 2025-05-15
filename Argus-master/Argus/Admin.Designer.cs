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
            this.btn_addInventory = new System.Windows.Forms.Button();
            this.btn_deleteINV = new System.Windows.Forms.Button();
            this.btn_acc = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
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
            this.lbl_username.Location = new System.Drawing.Point(183, 29);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(119, 32);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Argus";
            // 
            // btn_register_acc
            // 
            this.btn_register_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register_acc.Location = new System.Drawing.Point(50, 105);
            this.btn_register_acc.Name = "btn_register_acc";
            this.btn_register_acc.Size = new System.Drawing.Size(384, 115);
            this.btn_register_acc.TabIndex = 9;
            this.btn_register_acc.Text = "REGISTER ACC";
            this.btn_register_acc.UseVisualStyleBackColor = true;
            this.btn_register_acc.Click += new System.EventHandler(this.btn_register_acc_Click);
            // 
            // btn_addInventory
            // 
            this.btn_addInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addInventory.Location = new System.Drawing.Point(50, 278);
            this.btn_addInventory.Name = "btn_addInventory";
            this.btn_addInventory.Size = new System.Drawing.Size(384, 115);
            this.btn_addInventory.TabIndex = 10;
            this.btn_addInventory.Text = "ADD PRODUCT";
            this.btn_addInventory.UseVisualStyleBackColor = true;
            this.btn_addInventory.Click += new System.EventHandler(this.btn_addInventory_Click);
            // 
            // btn_deleteINV
            // 
            this.btn_deleteINV.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteINV.Location = new System.Drawing.Point(50, 451);
            this.btn_deleteINV.Name = "btn_deleteINV";
            this.btn_deleteINV.Size = new System.Drawing.Size(384, 115);
            this.btn_deleteINV.TabIndex = 11;
            this.btn_deleteINV.Text = "DELETE PRODUCT";
            this.btn_deleteINV.UseVisualStyleBackColor = true;
            this.btn_deleteINV.Click += new System.EventHandler(this.btn_deleteINV_Click);
            // 
            // btn_acc
            // 
            this.btn_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc.Location = new System.Drawing.Point(717, 105);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(384, 135);
            this.btn_acc.TabIndex = 12;
            this.btn_acc.Text = "ACCOUNTS";
            this.btn_acc.UseVisualStyleBackColor = true;
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(50, 593);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(384, 115);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "UPDATE PRODUCT";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_acc);
            this.Controls.Add(this.btn_deleteINV);
            this.Controls.Add(this.btn_addInventory);
            this.Controls.Add(this.btn_register_acc);
            this.Controls.Add(this.header);
            this.Name = "Admin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_register_acc;
        private System.Windows.Forms.Button btn_addInventory;
        private System.Windows.Forms.Button btn_deleteINV;
        private System.Windows.Forms.Button btn_acc;
        private System.Windows.Forms.Button btn_update;
    }
}

