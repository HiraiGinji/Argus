namespace Argus
{
    partial class Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_discountpercent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_discount_receipt = new System.Windows.Forms.Label();
            this.lbl_customer_receipt = new System.Windows.Forms.Label();
            this.lbl_total_receipt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_date_receipt = new System.Windows.Forms.Label();
            this.lbl_transaction_receipt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_cashier = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_vat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_discountpercent
            // 
            this.lbl_discountpercent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_discountpercent.AutoSize = true;
            this.lbl_discountpercent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_discountpercent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discountpercent.ForeColor = System.Drawing.Color.Black;
            this.lbl_discountpercent.Location = new System.Drawing.Point(400, 444);
            this.lbl_discountpercent.Name = "lbl_discountpercent";
            this.lbl_discountpercent.Size = new System.Drawing.Size(46, 22);
            this.lbl_discountpercent.TabIndex = 99;
            this.lbl_discountpercent.Text = "------";
            this.lbl_discountpercent.Click += new System.EventHandler(this.lbl_discountpercent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 98;
            this.label6.Text = "Discount:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 97;
            this.label5.Text = "Customer:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_discount_receipt
            // 
            this.lbl_discount_receipt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_discount_receipt.AutoSize = true;
            this.lbl_discount_receipt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_discount_receipt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount_receipt.ForeColor = System.Drawing.Color.Black;
            this.lbl_discount_receipt.Location = new System.Drawing.Point(235, 444);
            this.lbl_discount_receipt.Name = "lbl_discount_receipt";
            this.lbl_discount_receipt.Size = new System.Drawing.Size(82, 22);
            this.lbl_discount_receipt.TabIndex = 96;
            this.lbl_discount_receipt.Text = "XXXXXX";
            this.lbl_discount_receipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_customer_receipt
            // 
            this.lbl_customer_receipt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_customer_receipt.AutoSize = true;
            this.lbl_customer_receipt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_customer_receipt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_receipt.ForeColor = System.Drawing.Color.Black;
            this.lbl_customer_receipt.Location = new System.Drawing.Point(306, 411);
            this.lbl_customer_receipt.Name = "lbl_customer_receipt";
            this.lbl_customer_receipt.Size = new System.Drawing.Size(130, 22);
            this.lbl_customer_receipt.TabIndex = 95;
            this.lbl_customer_receipt.Text = "XXXXXXXXXX";
            this.lbl_customer_receipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_customer_receipt.Click += new System.EventHandler(this.lbl_customer_receipt_Click);
            // 
            // lbl_total_receipt
            // 
            this.lbl_total_receipt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_total_receipt.AutoSize = true;
            this.lbl_total_receipt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_receipt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_receipt.ForeColor = System.Drawing.Color.Black;
            this.lbl_total_receipt.Location = new System.Drawing.Point(349, 542);
            this.lbl_total_receipt.Name = "lbl_total_receipt";
            this.lbl_total_receipt.Size = new System.Drawing.Size(87, 23);
            this.lbl_total_receipt.TabIndex = 94;
            this.lbl_total_receipt.Text = "0000000";
            this.lbl_total_receipt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_total_receipt.Click += new System.EventHandler(this.lbl_total_receipt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 93;
            this.label9.Text = "TOTAL:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl_date_receipt
            // 
            this.lbl_date_receipt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_date_receipt.AutoSize = true;
            this.lbl_date_receipt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date_receipt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_receipt.ForeColor = System.Drawing.Color.Black;
            this.lbl_date_receipt.Location = new System.Drawing.Point(235, 342);
            this.lbl_date_receipt.Name = "lbl_date_receipt";
            this.lbl_date_receipt.Size = new System.Drawing.Size(110, 22);
            this.lbl_date_receipt.TabIndex = 92;
            this.lbl_date_receipt.Text = "0000-00-00";
            this.lbl_date_receipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_date_receipt.Click += new System.EventHandler(this.lbl_date_receipt_Click);
            // 
            // lbl_transaction_receipt
            // 
            this.lbl_transaction_receipt.AutoSize = true;
            this.lbl_transaction_receipt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_transaction_receipt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transaction_receipt.ForeColor = System.Drawing.Color.Black;
            this.lbl_transaction_receipt.Location = new System.Drawing.Point(306, 309);
            this.lbl_transaction_receipt.Name = "lbl_transaction_receipt";
            this.lbl_transaction_receipt.Size = new System.Drawing.Size(87, 22);
            this.lbl_transaction_receipt.TabIndex = 91;
            this.lbl_transaction_receipt.Text = "0000000";
            this.lbl_transaction_receipt.Click += new System.EventHandler(this.lbl_transaction_receipt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 90;
            this.label2.Text = "Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 89;
            this.label1.Text = "Transaction Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(30, 643);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(416, 306);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Renatha Signature", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(182, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 66);
            this.label3.TabIndex = 100;
            this.label3.Text = "Argus";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 23);
            this.label4.TabIndex = 101;
            this.label4.Text = "_________________________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 102;
            this.label7.Text = "Cashier:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_cashier
            // 
            this.lbl_cashier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_cashier.AutoSize = true;
            this.lbl_cashier.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cashier.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cashier.ForeColor = System.Drawing.Color.Black;
            this.lbl_cashier.Location = new System.Drawing.Point(306, 376);
            this.lbl_cashier.Name = "lbl_cashier";
            this.lbl_cashier.Size = new System.Drawing.Size(58, 22);
            this.lbl_cashier.TabIndex = 103;
            this.lbl_cashier.Text = "--------";
            this.lbl_cashier.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_cashier.Click += new System.EventHandler(this.lbl_cashier_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(160, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 22);
            this.label8.TabIndex = 104;
            this.label8.Text = "Manila, Philippines";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(207, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 22);
            this.label10.TabIndex = 105;
            this.label10.Text = "8-7000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(160, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 22);
            this.label11.TabIndex = 106;
            this.label11.Text = "Tax No: 45363453";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(150, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 22);
            this.label12.TabIndex = 107;
            this.label12.Text = "argus01@gmail.com";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(26, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(420, 23);
            this.label13.TabIndex = 108;
            this.label13.Text = "_________________________________________";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(26, 565);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(420, 23);
            this.label14.TabIndex = 109;
            this.label14.Text = "_________________________________________";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(26, 607);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 23);
            this.label15.TabIndex = 110;
            this.label15.Text = "ITEMS:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(26, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 22);
            this.label16.TabIndex = 111;
            this.label16.Text = "VAT:";
            // 
            // lbl_vat
            // 
            this.lbl_vat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_vat.AutoSize = true;
            this.lbl_vat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vat.ForeColor = System.Drawing.Color.Black;
            this.lbl_vat.Location = new System.Drawing.Point(348, 479);
            this.lbl_vat.Name = "lbl_vat";
            this.lbl_vat.Size = new System.Drawing.Size(59, 22);
            this.lbl_vat.TabIndex = 112;
            this.lbl_vat.Text = "00.00";
            this.lbl_vat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 961);
            this.Controls.Add(this.lbl_vat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_cashier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_discountpercent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_discount_receipt);
            this.Controls.Add(this.lbl_customer_receipt);
            this.Controls.Add(this.lbl_total_receipt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_date_receipt);
            this.Controls.Add(this.lbl_transaction_receipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_discountpercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_discount_receipt;
        private System.Windows.Forms.Label lbl_customer_receipt;
        private System.Windows.Forms.Label lbl_total_receipt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_date_receipt;
        private System.Windows.Forms.Label lbl_transaction_receipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_vat;
        public System.Windows.Forms.Label lbl_cashier;
    }
}