namespace Cafe_Billing_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Items = new System.Windows.Forms.ComboBox();
            this.Categories = new System.Windows.Forms.Label();
            this.text_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.Net = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sub_Total = new System.Windows.Forms.TextBox();
            this.Total_Paid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.To_print = new System.Windows.Forms.Button();
            this.Save_item = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.Location = new System.Drawing.Point(301, 141);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(395, 28);
            this.Items.TabIndex = 1;
            this.Items.SelectedIndexChanged += new System.EventHandler(this.Items_SelectedIndexChanged);
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Location = new System.Drawing.Point(163, 144);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(89, 20);
            this.Categories.TabIndex = 2;
            this.Categories.Text = "Select Items";
            this.Categories.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(52, 239);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(128, 27);
            this.text_price.TabIndex = 3;
            this.text_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // text_quantity
            // 
            this.text_quantity.Location = new System.Drawing.Point(273, 239);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.Size = new System.Drawing.Size(128, 27);
            this.text_quantity.TabIndex = 5;
            this.text_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_quantity.TextChanged += new System.EventHandler(this.text_quantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_total
            // 
            this.text_total.Location = new System.Drawing.Point(491, 239);
            this.text_total.Name = "text_total";
            this.text_total.Size = new System.Drawing.Size(128, 27);
            this.text_total.TabIndex = 7;
            this.text_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(52, 290);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 217);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 355;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sub Total";
            // 
            // Net
            // 
            this.Net.Location = new System.Drawing.Point(618, 532);
            this.Net.Name = "Net";
            this.Net.Size = new System.Drawing.Size(140, 27);
            this.Net.TabIndex = 12;
            this.Net.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Discount";
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(352, 535);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(128, 27);
            this.Discount.TabIndex = 14;
            this.Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Net";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Sub_Total
            // 
            this.Sub_Total.Location = new System.Drawing.Point(95, 535);
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.Size = new System.Drawing.Size(128, 27);
            this.Sub_Total.TabIndex = 16;
            this.Sub_Total.Text = "0";
            this.Sub_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sub_Total.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Total_Paid
            // 
            this.Total_Paid.Location = new System.Drawing.Point(618, 570);
            this.Total_Paid.Name = "Total_Paid";
            this.Total_Paid.Size = new System.Drawing.Size(140, 27);
            this.Total_Paid.TabIndex = 18;
            this.Total_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_Paid.TextChanged += new System.EventHandler(this.Total_Paid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Paid";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(510, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 24);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Coffee";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(352, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 24);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tea";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Balance";
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(618, 621);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(140, 27);
            this.Balance.TabIndex = 22;
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(352, 589);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(112, 27);
            this.Remove_button.TabIndex = 24;
            this.Remove_button.Text = "Remove Items";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // To_print
            // 
            this.To_print.Location = new System.Drawing.Point(472, 710);
            this.To_print.Name = "To_print";
            this.To_print.Size = new System.Drawing.Size(112, 27);
            this.To_print.TabIndex = 25;
            this.To_print.Text = "Print";
            this.To_print.UseVisualStyleBackColor = true;
            this.To_print.Click += new System.EventHandler(this.button3_Click);
            // 
            // Save_item
            // 
            this.Save_item.Location = new System.Drawing.Point(195, 710);
            this.Save_item.Name = "Save_item";
            this.Save_item.Size = new System.Drawing.Size(112, 27);
            this.Save_item.TabIndex = 27;
            this.Save_item.Text = "Save";
            this.Save_item.UseVisualStyleBackColor = true;
            this.Save_item.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 786);
            this.Controls.Add(this.Save_item);
            this.Controls.Add(this.To_print);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Total_Paid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sub_Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Net);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "CafeBilling";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox Items;
        private Label Categories;
        private TextBox text_price;
        private Label label1;
        private Label label2;
        private TextBox text_quantity;
        private Label label3;
        private TextBox text_total;
        private Button button1;
        private ListView listView1;
        private Label label4;
        private TextBox Net;
        private Label label5;
        private TextBox Discount;
        private Label label6;
        private TextBox Sub_Total;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox Total_Paid;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label8;
        private TextBox Balance;
        private Button button2;
        private Button Remove_button;
        private Button To_print;
        private Button Save_item;
    }
}