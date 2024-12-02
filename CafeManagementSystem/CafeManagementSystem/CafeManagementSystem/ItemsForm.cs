using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DUCTOAN;Initial Catalog=SystemManagerCafe;Integrated Security=True;Encrypt=False");


      
        //
        private void populate()
        {
            // Ví dụ về việc truy vấn và điền dữ liệu vào DataGridView
            try
            {
                Con.Open();
                string query = "SELECT * FROM ItemTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ItemGV.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }



        //






//
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            // Kiểm tra xem có hàng nào được chọn hay không
            if (ItemGV.SelectedRows.Count > 0)
            {
                // Chỉ số của hàng được chọn đầu tiên là 0
                DataGridViewRow selectedRow = ItemGV.SelectedRows[0];

                // Kiểm tra từng ô để đảm bảo rằng không có ô nào null trước khi truy cập giá trị của chúng
                if (selectedRow.Cells[0].Value != null)
                {
                    ItemNumTB.Text = selectedRow.Cells[0].Value.ToString();
                }
                if (selectedRow.Cells[1].Value != null)
                {
                    ItemNameTB.Text = selectedRow.Cells[1].Value.ToString();
                }
                if (selectedRow.Cells[2].Value != null)
                {
                    CatCB.SelectedItem = selectedRow.Cells[2].Value.ToString();
                }
                if (selectedRow.Cells[3].Value != null)
                {
                    ItemPrice.Text = selectedRow.Cells[3].Value.ToString();
                }
            }
            else
            {
                // Xử lý trường hợp không có hàng nào được chọn, nếu cần
                MessageBox.Show("No row is selected.");
            }


            //



            ItemNumTB.Text = ItemGV.SelectedRows[0].Cells[0].Value.ToString();
            ItemNameTB.Text = ItemGV.SelectedRows[0].Cells[1].Value.ToString();
            CatCB.SelectedItem =  ItemGV.SelectedRows[0].Cells[2].Value.ToString();
            ItemPrice.Text = ItemGV.SelectedRows[0].Cells[3].Value.ToString();






        }


        




        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uorder = new UserOrder();
            uorder.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemNameTB.Text == "" || ItemNumTB.Text == "" || ItemPrice.Text == "")
            {
                MessageBox.Show("Fill All the Filleds");
            }
            else
            {   

                Con.Open();
                string query = " insert into ItemTbl values ('" + ItemNumTB.Text + "', '" + ItemNameTB.Text + "', '" + CatCB.SelectedItem.ToString() + "', " + ItemPrice.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Created");
                Con.Close();
                populate();
                reset();
            }
        }








        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "delete from ItemTbl where ItemNum= '" + ItemNumTB.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Deleted Successfuly ");
                Con.Close();
                populate();
               reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
















        private void EditBtn_Click(object sender, EventArgs e)
        {

            //
            if (ItemNumTB.Text == "" || ItemNameTB.Text == "" || ItemPrice.Text == "")
            {
                MessageBox.Show("Fill All the Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    // Sử dụng truy vấn có tham số để tránh SQL Injection
                    string query = "UPDATE ItemTbl SET ItemName = @ItemName, ItemCat = @ItemCat WHERE ItemPrice = @ItemPrice";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    // Thêm các tham số
                    cmd.Parameters.AddWithValue("@ItemName", ItemNameTB.Text);
                    cmd.Parameters.AddWithValue("@ItemCat", CatCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ItemPrice", ItemPrice.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Item Successfully Updated");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }


            //

            if (ItemNumTB.Text == "" || ItemNameTB.Text == "" || ItemPrice.Text == "")
            {
                MessageBox.Show("Fill All the Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE ItemTbl SET ItemName = @ItemName, ItemCat = @ItemCat WHERE ItemPrice = @ItemPrice";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@ItemName", ItemNameTB.Text);
                    cmd.Parameters.AddWithValue("@ItemCat", CatCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ItemPrice", ItemPrice.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Item Successfully Updated");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }




            //


















































            if (ItemNumTB.Text == "" || ItemNameTB.Text == "" || ItemPrice.Text == "" )
            {
                MessageBox.Show("Fill All the Data");

            }
            else
            {
                Con.Open();
                string query = " update ItemTbl set ItemName= '" + ItemNameTB.Text + "',ItemCat='" + CatCB.SelectedItem.ToString() + "' where ItemPrice " +  ItemPrice.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Seccessfully Updated");
                Con.Close();
                populate();
               reset();
            }
        
         }




        public void reset()
        {
            ItemNumTB.Text = "";
            ItemNameTB.Text = "";
            CatCB.SelectedItem = -1;
            ItemPrice.Text = "";

        }

        private void CatCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemNumTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populate();
        }
    }
}
