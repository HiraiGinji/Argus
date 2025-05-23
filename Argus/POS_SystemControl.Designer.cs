﻿namespace Argus
{
    partial class POS_SystemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_gcash = new System.Windows.Forms.RadioButton();
            this.rb_cash = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_discount = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.tb_customer = new System.Windows.Forms.TextBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.CameraListbox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_transaction = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.tb_pid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbl_cart = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemPrice.Location = new System.Drawing.Point(-26, 3);
            this.lbl_itemPrice.MinimumSize = new System.Drawing.Size(300, 86);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(300, 86);
            this.lbl_itemPrice.TabIndex = 63;
            this.lbl_itemPrice.Text = "0.00";
            this.lbl_itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(147, 60);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(126, 25);
            this.lbl_date.TabIndex = 104;
            this.lbl_date.Text = "0000-00-00";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_money);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lbl_change);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rb_gcash);
            this.panel2.Controls.Add(this.rb_cash);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cb_discount);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.lbl_discount);
            this.panel2.Controls.Add(this.lbl_subtotal);
            this.panel2.Controls.Add(this.tb_customer);
            this.panel2.Controls.Add(this.btn_pay);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(779, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 625);
            this.panel2.TabIndex = 117;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tb_money
            // 
            this.tb_money.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_money.ForeColor = System.Drawing.Color.Black;
            this.tb_money.Location = new System.Drawing.Point(144, 486);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(163, 33);
            this.tb_money.TabIndex = 123;
            this.tb_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_money_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 489);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 25);
            this.label14.TabIndex = 122;
            this.label14.Text = "Money:";
            // 
            // lbl_change
            // 
            this.lbl_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_change.AutoSize = true;
            this.lbl_change.BackColor = System.Drawing.Color.Transparent;
            this.lbl_change.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_change.ForeColor = System.Drawing.Color.White;
            this.lbl_change.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_change.Location = new System.Drawing.Point(212, 242);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(66, 25);
            this.lbl_change.TabIndex = 121;
            this.lbl_change.Text = "00.00";
            this.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 120;
            this.label11.Text = "Change:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 25);
            this.label7.TabIndex = 119;
            this.label7.Text = "_________________________";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rb_gcash
            // 
            this.rb_gcash.AutoSize = true;
            this.rb_gcash.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.rb_gcash.ForeColor = System.Drawing.Color.White;
            this.rb_gcash.Location = new System.Drawing.Point(217, 316);
            this.rb_gcash.Name = "rb_gcash";
            this.rb_gcash.Size = new System.Drawing.Size(105, 29);
            this.rb_gcash.TabIndex = 118;
            this.rb_gcash.TabStop = true;
            this.rb_gcash.Text = "GCASH";
            this.rb_gcash.UseVisualStyleBackColor = true;
            // 
            // rb_cash
            // 
            this.rb_cash.AutoSize = true;
            this.rb_cash.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.rb_cash.ForeColor = System.Drawing.Color.White;
            this.rb_cash.Location = new System.Drawing.Point(127, 316);
            this.rb_cash.Name = "rb_cash";
            this.rb_cash.Size = new System.Drawing.Size(87, 29);
            this.rb_cash.TabIndex = 117;
            this.rb_cash.TabStop = true;
            this.rb_cash.Text = "CASH";
            this.rb_cash.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(17, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 25);
            this.label13.TabIndex = 116;
            this.label13.Text = "Payment:";
            this.label13.Click += new System.EventHandler(this.label5_Click);
            // 
            // cb_discount
            // 
            this.cb_discount.BackColor = System.Drawing.SystemColors.Control;
            this.cb_discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_discount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cb_discount.FormattingEnabled = true;
            this.cb_discount.Items.AddRange(new object[] {
            "Regular",
            "PWD",
            "Senior Citizen"});
            this.cb_discount.Location = new System.Drawing.Point(144, 426);
            this.cb_discount.Name = "cb_discount";
            this.cb_discount.Size = new System.Drawing.Size(163, 33);
            this.cb_discount.TabIndex = 78;
            this.cb_discount.SelectedIndexChanged += new System.EventHandler(this.cb_discount_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(18, 429);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 25);
            this.label15.TabIndex = 77;
            this.label15.Text = "Discount:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total.Location = new System.Drawing.Point(211, 205);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(96, 25);
            this.lbl_total.TabIndex = 76;
            this.lbl_total.Text = "0000000";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_discount
            // 
            this.lbl_discount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_discount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_discount.ForeColor = System.Drawing.Color.White;
            this.lbl_discount.Location = new System.Drawing.Point(235, 164);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_discount.Size = new System.Drawing.Size(66, 25);
            this.lbl_discount.TabIndex = 75;
            this.lbl_discount.Text = "------";
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_discount.Click += new System.EventHandler(this.lbl_discount_Click);
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_subtotal.ForeColor = System.Drawing.Color.White;
            this.lbl_subtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_subtotal.Location = new System.Drawing.Point(209, 122);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(66, 25);
            this.lbl_subtotal.TabIndex = 73;
            this.lbl_subtotal.Text = "00.00";
            this.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_customer
            // 
            this.tb_customer.BackColor = System.Drawing.SystemColors.Control;
            this.tb_customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_customer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_customer.Location = new System.Drawing.Point(144, 365);
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(163, 33);
            this.tb_customer.TabIndex = 72;
            this.tb_customer.TextChanged += new System.EventHandler(this.tb_customer_TextChanged);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pay.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.Location = new System.Drawing.Point(15, 539);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(292, 68);
            this.btn_pay.TabIndex = 71;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 65;
            this.label10.Text = "Customer:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 64;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 63;
            this.label8.Text = "Discount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Sub-Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_itemPrice);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(14, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 82);
            this.panel1.TabIndex = 105;
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Enabled = false;
            this.txt_Barcode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Barcode.Location = new System.Drawing.Point(488, 604);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(285, 35);
            this.txt_Barcode.TabIndex = 114;
            this.txt_Barcode.TextChanged += new System.EventHandler(this.txt_Barcode_TextChanged);
            // 
            // CameraListbox
            // 
            this.CameraListbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraListbox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraListbox.FormattingEnabled = true;
            this.CameraListbox.Location = new System.Drawing.Point(490, 510);
            this.CameraListbox.Name = "CameraListbox";
            this.CameraListbox.Size = new System.Drawing.Size(285, 38);
            this.CameraListbox.TabIndex = 115;
            this.CameraListbox.SelectedIndexChanged += new System.EventHandler(this.CameraListbox_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(488, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 129);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_transaction
            // 
            this.lbl_transaction.AutoSize = true;
            this.lbl_transaction.BackColor = System.Drawing.Color.Transparent;
            this.lbl_transaction.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_transaction.ForeColor = System.Drawing.Color.White;
            this.lbl_transaction.Location = new System.Drawing.Point(273, 23);
            this.lbl_transaction.Name = "lbl_transaction";
            this.lbl_transaction.Size = new System.Drawing.Size(96, 25);
            this.lbl_transaction.TabIndex = 103;
            this.lbl_transaction.Text = "0000000";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_date);
            this.panel3.Controls.Add(this.lbl_transaction);
            this.panel3.Controls.Add(this.tb_qty);
            this.panel3.Controls.Add(this.tb_pid);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(13, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 101);
            this.panel3.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "TRANSACTION NUMBER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = "DATE:";
            // 
            // tb_qty
            // 
            this.tb_qty.BackColor = System.Drawing.SystemColors.Control;
            this.tb_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_qty.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_qty.Location = new System.Drawing.Point(548, 56);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(201, 33);
            this.tb_qty.TabIndex = 110;
            this.tb_qty.Text = "1";
            this.tb_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_qty_KeyDown);
            // 
            // tb_pid
            // 
            this.tb_pid.BackColor = System.Drawing.SystemColors.Control;
            this.tb_pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pid.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tb_pid.Location = new System.Drawing.Point(548, 15);
            this.tb_pid.Name = "tb_pid";
            this.tb_pid.Size = new System.Drawing.Size(201, 33);
            this.tb_pid.TabIndex = 108;
            this.tb_pid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_pid_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(419, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 107;
            this.label3.Text = "Product ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(419, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 109;
            this.label4.Text = "Quantity:";
            // 
            // tbl_cart
            // 
            this.tbl_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_cart.Location = new System.Drawing.Point(13, 121);
            this.tbl_cart.Name = "tbl_cart";
            this.tbl_cart.Size = new System.Drawing.Size(760, 518);
            this.tbl_cart.TabIndex = 116;
            this.tbl_cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_cart_CellContentClick);
            this.tbl_cart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_cart_CellDoubleClick);
            // 
            // POS_SystemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbl_cart);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CameraListbox);
            this.Name = "POS_SystemControl";
            this.Size = new System.Drawing.Size(1121, 655);
            this.Load += new System.EventHandler(this.POS_SystemControl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.POS_SystemControl_KeyDown);
            this.Leave += new System.EventHandler(this.POS_SystemControl_Leave);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_itemPrice;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_discount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox tb_customer;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_transaction;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.TextBox tb_pid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tbl_cart;
        private System.Windows.Forms.ComboBox CameraListbox;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.RadioButton rb_gcash;
        private System.Windows.Forms.RadioButton rb_cash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_money;
    }
}
