using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CafeManagementSystem
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DUCTOAN;Initial Catalog=SystemManagerCafe;Integrated Security=True;Encrypt=False");

        void populate()
        {
            Con.Open();
            string query = "select * from [UserTbl]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            Con.Close();



        }




        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm item = new ItemsForm();
            item.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm uorder = new UsersForm();
            uorder.Show();
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

        private void uphoneTB_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void UsersForm_Load(object sender, EventArgs e)
        {
            populate();
           
        }

      
       
      




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uorder = new UserOrder();
            uorder.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Items = new ItemsForm();
            Items.Show();

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string query = " insert into [UserTbl] values ('" + unameTB.Text + "', '" + uphoneTB.Text + "', '" + upassTB.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully Created");
            Con.Close();
            populate();
           // reset();
        }

        private void UsersGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)//
        {

            unameTB.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            uphoneTB.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            upassTB.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string name = unameTB.Text;
            string sql = "DELETE from [UserTbl] WHERE UName='" + name + "'";
            SqlCommand cmd = new SqlCommand(sql, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            Con.Close();
        }




        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (unameTB.Text == "" || uphoneTB.Text == "" || upassTB.Text == "")
            {
                MessageBox.Show("Fill All the Field");

            }
            else
            {
                Con.Open();
                string oldName = unameTB.Text;
                string newName = uphoneTB.Text;
                string oldSql = upassTB.Text;
                string sql = "UPDATE [UserTbl]   set Uname= '" + unameTB.Text + "', UPassword= '" + upassTB.Text + "'where Uphone ='" + uphoneTB.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                Con.Close();
            }
        }







        public void reset()
        {
            unameTB.Text = "";
            upassTB.Text = "";
            uphoneTB.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder order = new GuestOrder();
            order.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void unameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



