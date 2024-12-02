using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DUCTOAN;Initial Catalog=SystemManagerCafe;Integrated Security=True;Encrypt=False");






        // yếu tố xác thực chế độ thoát  Khi người dùng nhấn nút Exit, bạn chỉ gọi Application.Exit() mà không đóng kết nối cơ sở dữ liệu.Điều này có thể gây rò rỉ tài nguyên.
        private void button2_Click(object sender, EventArgs e)
        {

            if (Con != null && Con.State == ConnectionState.Open)
            {
                Con.Close();
            }

            Application.Exit();
        }
        // 





        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder Ord = new GuestOrder();
            Ord.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static string User;

        private void button1_Click(object sender, EventArgs e)
        {
            User = unameTb.Text;
           
           if(unameTb.Text == "" || PasswordTb.Text =="")
            {
                MessageBox.Show("Please Enter Username OR Password");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sad = new SqlDataAdapter("select count(*) from UserTbl where Uname ='" + unameTb.Text + "'and  UPassword = '" + PasswordTb.Text + "'",Con );
                DataTable dt = new DataTable();
                sad.Fill(dt);
                if (dt.Rows[0][0].ToString () == "1")
                {
                    this.Hide();
                    UserOrder Uorder = new UserOrder();
                    Uorder.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username OR Password ");
                }
                Con.Close();

            }
        }


       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

    
}


