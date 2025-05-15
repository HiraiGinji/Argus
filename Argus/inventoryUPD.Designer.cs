namespace Argus
{
    partial class inventoryUPD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryUPD));
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.tbl_records = new System.Windows.Forms.DataGridView();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.nud_qty = new System.Windows.Forms.NumericUpDown();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_search.Location = new System.Drawing.Point(700, 351);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(136, 44);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.UseWaitCursor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_pid
            // 
            this.txt_pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pid.Location = new System.Drawing.Point(328, 351);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(362, 44);
            this.txt_pid.TabIndex = 28;
            this.txt_pid.UseWaitCursor = true;
            this.txt_pid.TextChanged += new System.EventHandler(this.txt_pid_TextChanged);
            // 
            // txt_pname
            // 
            this.txt_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pname.Location = new System.Drawing.Point(328, 301);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(362, 44);
            this.txt_pname.TabIndex = 26;
            this.txt_pname.UseWaitCursor = true;
            // 
            // tbl_records
            // 
            this.tbl_records.BackgroundColor = System.Drawing.Color.White;
            this.tbl_records.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tbl_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_records.Location = new System.Drawing.Point(123, 425);
            this.tbl_records.Name = "tbl_records";
            this.tbl_records.Size = new System.Drawing.Size(1112, 276);
            this.tbl_records.TabIndex = 30;
            this.tbl_records.UseWaitCursor = true;
            // 
            // nud_price
            // 
            this.nud_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_price.Location = new System.Drawing.Point(1105, 299);
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(142, 38);
            this.nud_price.TabIndex = 34;
            this.nud_price.UseWaitCursor = true;
            // 
            // nud_qty
            // 
            this.nud_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_qty.Location = new System.Drawing.Point(826, 299);
            this.nud_qty.Name = "nud_qty";
            this.nud_qty.Size = new System.Drawing.Size(186, 40);
            this.nud_qty.TabIndex = 31;
            this.nud_qty.UseWaitCursor = true;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_update.Location = new System.Drawing.Point(1099, 657);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(136, 44);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.UseWaitCursor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_back.Location = new System.Drawing.Point(50, 492);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 44);
            this.btn_back.TabIndex = 36;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.UseWaitCursor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1368, 763);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(1105, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 44);
            this.button1.TabIndex = 38;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // inventoryUPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1363, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tbl_records);
            this.Controls.Add(this.nud_price);
            this.Controls.Add(this.nud_qty);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.txt_pid);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Name = "inventoryUPD";
            this.Text = "inventoryUPD";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.inventoryUPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_pid;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.DataGridView tbl_records;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.NumericUpDown nud_qty;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}