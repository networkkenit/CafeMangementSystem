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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DUCTOAN;Initial Catalog=SystemManagerCafe;Integrated Security=True;Encrypt=False");

        void populate()
        {
            Con.Open();
            string query = "select * from [OrdersTbl]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            Con.Close();
            
        }



        private void AddToCatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Check if any row is selected
            if (OrdersGV.SelectedRows.Count > 0)
            {
                var selectedRow = OrdersGV.SelectedRows[0];

                e.Graphics.DrawString("*************My Love Cafe***************",
                    new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(170, 50));
                e.Graphics.DrawString("*************Orders Summary**************",
                    new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(220, 75));
                e.Graphics.DrawString("Order No       :  " + selectedRow.Cells[0].Value.ToString(),
                    new Font("Abeezee", 12, FontStyle.Bold), Brushes.Black, new Point(120, 105));
                e.Graphics.DrawString("Order Date     :  " + selectedRow.Cells[1].Value.ToString(),
                    new Font("Abeezee", 12, FontStyle.Bold), Brushes.Black, new Point(120, 135));
                e.Graphics.DrawString("Seller Name    :  " + selectedRow.Cells[2].Value.ToString(),
                    new Font("Abeezee", 12, FontStyle.Bold), Brushes.Black, new Point(120, 165));
                e.Graphics.DrawString("Order Amount   :  " + selectedRow.Cells[3].Value.ToString(),
                    new Font("Abeezee", 12, FontStyle.Bold), Brushes.Black, new Point(120, 195));
            }
            else
            {
                e.Graphics.DrawString("No order selected for printing.",
                    new Font("Abeezee", 12, FontStyle.Bold), Brushes.Black, new Point(120, 105));
            }


        }

        public void RefreshOrders()
        {
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=DUCTOAN;Initial Catalog=SystemManagerCafe;Integrated Security=True;Encrypt=False");
                Con.Open();
                string query = "SELECT * FROM [OrdersTbl]";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                OrdersGV.DataSource = ds.Tables[0]; // OrdersGV is the DataGridView in ViewOrders
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing orders: " + ex.Message);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

            this.Hide();
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.Show();
            viewOrders.RefreshOrders(); // Refresh the orders to display the latest data
        }
    }



}
