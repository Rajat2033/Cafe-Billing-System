namespace Cafe_Billing_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;
            Items.Items.Clear();
            Items.Items.Add("Elaaichi Chai");
            Items.Items.Add("Masala Chai");
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            Items.Items.Clear();
            Items.Items.Add("Hot Coffee");
            Items.Items.Add("Cold Coffee");
           
        }

        private void Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Items.SelectedItem.ToString()== "Elaaichi Chai")
            {
                text_price.Text = "20";
            }
            else if(Items.SelectedItem.ToString()== "Masala Chai")
            {
                text_price.Text = "15";
            }
            else if(Items.SelectedItem.ToString()=="Hot Coffee")
            {
                text_price.Text = "50";
            }
            else if(Items.SelectedItem.ToString() =="Cold Coffee")
            {
                text_price.Text = "70";
            }
            else
            {
                text_price.Text = "0";
            }
            text_quantity.Text = "";
            text_total.Text = "";
        }

        private void text_quantity_TextChanged(object sender, EventArgs e)
        {
            if(text_quantity.Text.Length>0)
            { 
            text_total.Text = (Convert.ToInt16(text_price.Text) * Convert.ToInt16(text_quantity.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arr = new string[4];
            arr[0] = Items.SelectedItem.ToString();
            arr[1] = text_price.Text;
            arr[2] = text_quantity.Text;
            arr[3] = text_total.Text;

            ListViewItem lvl = new ListViewItem(arr);
            listView1.Items.Add(lvl);


            Sub_Total.Text = (Convert.ToInt32(Sub_Total.Text) + Convert.ToInt32(text_total.Text)).ToString();
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            if(Discount.Text.Length>0)
            {
                Net.Text = (Convert.ToInt16(Sub_Total.Text) - Convert.ToInt16(Discount.Text)).ToString();

            }
        }

        private void Total_Paid_TextChanged(object sender, EventArgs e)
        {
            if(Total_Paid.Text.Length>0)
            {
                Balance.Text = (Convert.ToInt16(Net.Text) - Convert.ToInt16(Total_Paid.Text)).ToString();
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                for(int i=0;i<listView1.Items.Count;i++)
                {
                    if (listView1.Items[i].Selected) {
                    Sub_Total.Text = (Convert.ToInt16(Sub_Total.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                    listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*****Hello Customer*****"+
                "\nTotal Amount : "+Sub_Total.Text+
                "\nDiscount Applied : " + Discount.Text + 
                "\nTotal Amount Paid : " + Total_Paid.Text + 
                "\nBalance Amount : " + Balance.Text);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Clear_Item_Click(object sender, EventArgs e)
        {

        }
    }
}