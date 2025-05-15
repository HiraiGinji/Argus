namespace Argus
{
    partial class inventoryADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryADD));
            this.tbl_records = new System.Windows.Forms.DataGridView();
            this.nud_qty = new System.Windows.Forms.NumericUpDown();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_records
            // 
            this.tbl_records.BackgroundColor = System.Drawing.Color.White;
            this.tbl_records.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tbl_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_records.Location = new System.Drawing.Point(123, 384);
            this.tbl_records.Name = "tbl_records";
            this.tbl_records.Size = new System.Drawing.Size(1121, 291);
            this.tbl_records.TabIndex = 0;
            this.tbl_records.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_records_CellContentClick);
            // 
            // nud_qty
            // 
            this.nud_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_qty.Location = new System.Drawing.Point(736, 300);
            this.nud_qty.Name = "nud_qty";
            this.nud_qty.Size = new System.Drawing.Size(131, 40);
            this.nud_qty.TabIndex = 3;
            // 
            // txt_pname
            // 
            this.txt_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pname.Location = new System.Drawing.Point(334, 300);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(253, 44);
            this.txt_pname.TabIndex = 8;
            // 
            // nud_price
            // 
            this.nud_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_price.Location = new System.Drawing.Point(1021, 301);
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(170, 38);
            this.nud_price.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_back.Location = new System.Drawing.Point(1103, 198);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(142, 44);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1365, 792);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_add.Location = new System.Drawing.Point(1102, 631);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(142, 44);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // inventoryADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1357, 749);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tbl_records);
            this.Controls.Add(this.nud_price);
            this.Controls.Add(this.nud_qty);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "inventoryADD";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventoryADD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inventoryADD_FormClosing);
            this.Load += new System.EventHandler(this.inventoryADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbl_records;
        private System.Windows.Forms.NumericUpDown nud_qty;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add;
    }
}