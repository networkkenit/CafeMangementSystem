using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DUCTOAN;Initial Catalog=SystemManagerCafe;Integrated Security=True;Encrypt=False");

        void populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();

        }


        void Filterbycategory()
        {
            Con.Open();
            string query = "select * from ItemTbl where ItemCat ='" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm ufrom = new UsersForm();
            ufrom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Items = new ItemsForm();
            Items.Show();
        }


        private void button1_Click(object sender, EventArgs e)//
        {


            if (QT.Text == "")
            {
                MessageBox.Show("What is the Quantity");

            }

            else if (flag == 0)
            {
                MessageBox.Show("Select  the product to b ordered");
            }

            else
            {
                num = num + 1;
                Total = Price * Convert.ToInt32(QT.Text);
                table1.Rows.Add(num, item, Cat, Price, Total);
                dataGridView1.DataSource = table1;
                flag = 0;


            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filterbycategory();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//
        {

            item = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Cat = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void button8_Click(object sender, EventArgs e)//
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)//
        {
            
        }

        private void button7_Click(object sender, EventArgs e)//
        {
            this.Hide();
            UsersForm uform = new UsersForm();
            uform.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)//
        {
            this.Hide();
            ItemsForm Items = new ItemsForm();
            Items.Show();
        }


        private void SellerNameBtn_TextChanged(object sender, EventArgs e)//
        {
            this.Hide();
            ItemsForm Items = new ItemsForm();
            Items.Show();
        }


        private void OrderNumBtn_TextChanged(object sender, EventArgs e)//
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//
        {

        }












        //// cải tiến 



        private void PlaceOrder_Click(object sender, EventArgs e)//
        {

            Con.Open();
            string query = " Insert into [OrdersTbl] values ('" + OrderNumBtn.Text + "', '" + DateLbl.Text + "', '" + SellerNameBtn.Text + "','" + OrderAmtLb.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.Clear();
            MessageBox.Show("Order Successfully Created");
            Con.Close();




        }






        private void label5_Click(object sender, EventArgs e)//
        {

        }

        private void OrderAmtLb_Click(object sender, EventArgs e)//
        {
            
        }

        private void OrderNumBtn_TextChanged_1(object sender, EventArgs e)
        {

            

        }

        DataTable table1 = new DataTable();

        int flag = 0;
        int sum = 0;
            
        private void UserOrder_Load_1(object sender, EventArgs e)//
        {
            
            populate();
            table1.Columns.Add("Num", typeof(int ));
            table1.Columns.Add("Item", typeof(String));
            table1.Columns.Add("Category", typeof(String));
            table1.Columns.Add("UnitPrice", typeof(int));
            table1.Columns.Add("Total", typeof(int));
            dataGridView2.DataSource = table1;
            DateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            SellerNameBtn.Text = Form1.User;

        }

        int num = 0;
        int Total, Price, Qty;
        string item, Cat;

        private void button1_Click_1(object sender, EventArgs e)
        {
            populate();

        }

        private void DateLbl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filterbycategory();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddToCatBtn_Click(object sender, EventArgs e)
        {
            if(QtyTB.Text=="")
            {
                MessageBox.Show("What is the Quantity");

            }

            else if (flag == 0)
            {
                MessageBox.Show("Select  the product to b ordered");
            }

            else
            {
                num = num + 1;
                Total = Price * Convert.ToInt32(QT.Text);
                table1.Rows.Add(num,item, Cat, Price, Total);
                dataGridView2.DataSource = table1;
                flag = 0;   
            }
            sum = sum + Total;
            OrderAmtLbl.Text = " RS :   " + sum;
        }
    }

}
