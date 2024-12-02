using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
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





        /// Code Phòng ngừa SQL Injection
        void Filterbycategory()
        {


            Con.Open();
            string query = "SELECT * FROM ItemTbl WHERE ItemCat = @ItemCat";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@ItemCat", comboBox1.SelectedItem.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
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

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            populate();
            table1.Columns.Add("Num", typeof(int));
            table1.Columns.Add("Item", typeof(String));
            table1.Columns.Add("Category", typeof(String));
            table1.Columns.Add("UnitPrice", typeof(int));
            table1.Columns.Add("Total", typeof(int));
            dataGridView2.DataSource = table1;
            DateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();


        }
        int num = 0;
        int Total, Price, Qty;
        string item, Cat;

        DataTable table1 = new DataTable();

        int flag = 0, sum = 0;

        private void DateLbl_Click(object sender, EventArgs e)
        {

        }





// fix bug exit form1




        private void button2_Click(object sender, EventArgs e)
        {



        }





        // fix bug 





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderAmtLb_Click(object sender, EventArgs e)
        {

        }

        private void OrderNumTb_TextChanged(object sender, EventArgs e)
        {
          
        }
    



        // code cải tiến 

        private void button1_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(QT.Text) || !int.TryParse(QT.Text, out Qty) || Qty <= 0)
            {
                MessageBox.Show("What is the Quantity.");
                return;
            }

            if (flag == 0)
            {
                MessageBox.Show("Select the product to be ordered.");
                return;
            }

            num++;
            Total = Price * Qty;
            table1.Rows.Add(num, item, Cat, Price, Total);
            dataGridView2.DataSource = table1; // Đảm bảo đây là DataGridView chính xác
            sum += Total;
            OrderAmtLb.Text = sum.ToString();

            //Xóa lựa chọn và đặt lại các trường
            QT.Text = "";
            flag = 0;
            dataGridView1.ClearSelection();





        }



        /// 
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Cat = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filterbycategory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();

        
        }
        
    }
}
