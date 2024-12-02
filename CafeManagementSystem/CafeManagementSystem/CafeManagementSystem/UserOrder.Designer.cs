namespace CafeManagementSystem
{
    partial class UserOrder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.DateLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PlaceOrder = new System.Windows.Forms.Button();
            this.QT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddToCatBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.OrderAmtLb = new System.Windows.Forms.Label();
            this.SellerNameBtn = new System.Windows.Forms.TextBox();
            this.OrderNumBtn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.DateLbl);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PlaceOrder);
            this.panel2.Controls.Add(this.QT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AddToCatBtn);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.OrderAmtLb);
            this.panel2.Controls.Add(this.SellerNameBtn);
            this.panel2.Controls.Add(this.OrderNumBtn);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(322, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 743);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DeepPink;
            this.button2.Location = new System.Drawing.Point(851, 654);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 48);
            this.button2.TabIndex = 30;
            this.button2.Text = "View Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font(".Vn3DH", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.DeepPink;
            this.DateLbl.Location = new System.Drawing.Point(828, 0);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(107, 50);
            this.DateLbl.TabIndex = 29;
            this.DateLbl.Text = "Date";
            this.DateLbl.Click += new System.EventHandler(this.DateLbl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(0, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 48);
            this.button1.TabIndex = 28;
            this.button1.Text = "Refersh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(463, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 42);
            this.label3.TabIndex = 27;
            this.label3.Text = "Place Order";
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrder.ForeColor = System.Drawing.Color.DeepPink;
            this.PlaceOrder.Location = new System.Drawing.Point(206, 654);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(234, 48);
            this.PlaceOrder.TabIndex = 26;
            this.PlaceOrder.Text = "Place the Order";
            this.PlaceOrder.UseVisualStyleBackColor = true;
            this.PlaceOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // QT
            // 
            this.QT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QT.ForeColor = System.Drawing.Color.Salmon;
            this.QT.Location = new System.Drawing.Point(480, 247);
            this.QT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QT.Multiline = true;
            this.QT.Name = "QT";
            this.QT.Size = new System.Drawing.Size(238, 46);
            this.QT.TabIndex = 25;
            this.QT.Text = "Quantity";
            this.QT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font(".Vn3DH", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(471, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 50);
            this.label5.TabIndex = 24;
            this.label5.Text = "Your Order";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddToCatBtn
            // 
            this.AddToCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCatBtn.ForeColor = System.Drawing.Color.DeepPink;
            this.AddToCatBtn.Location = new System.Drawing.Point(480, 301);
            this.AddToCatBtn.Name = "AddToCatBtn";
            this.AddToCatBtn.Size = new System.Drawing.Size(234, 48);
            this.AddToCatBtn.TabIndex = 23;
            this.AddToCatBtn.Text = "Add To Cart";
            this.AddToCatBtn.UseVisualStyleBackColor = true;
            this.AddToCatBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(260, 415);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(751, 211);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // OrderAmtLb
            // 
            this.OrderAmtLb.AutoSize = true;
            this.OrderAmtLb.Font = new System.Drawing.Font(".Vn3DH", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAmtLb.ForeColor = System.Drawing.Color.DeepPink;
            this.OrderAmtLb.Location = new System.Drawing.Point(501, 654);
            this.OrderAmtLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderAmtLb.Name = "OrderAmtLb";
            this.OrderAmtLb.Size = new System.Drawing.Size(281, 50);
            this.OrderAmtLb.TabIndex = 21;
            this.OrderAmtLb.Text = "Order Amount";
            this.OrderAmtLb.Click += new System.EventHandler(this.OrderAmtLb_Click);
            // 
            // SellerNameBtn
            // 
            this.SellerNameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNameBtn.ForeColor = System.Drawing.Color.Orange;
            this.SellerNameBtn.Location = new System.Drawing.Point(4, 196);
            this.SellerNameBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerNameBtn.Multiline = true;
            this.SellerNameBtn.Name = "SellerNameBtn";
            this.SellerNameBtn.Size = new System.Drawing.Size(190, 46);
            this.SellerNameBtn.TabIndex = 20;
            this.SellerNameBtn.Text = "Seller Name";
            this.SellerNameBtn.TextChanged += new System.EventHandler(this.SellerNameBtn_TextChanged);
            // 
            // OrderNumBtn
            // 
            this.OrderNumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumBtn.ForeColor = System.Drawing.Color.Salmon;
            this.OrderNumBtn.Location = new System.Drawing.Point(4, 123);
            this.OrderNumBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderNumBtn.Multiline = true;
            this.OrderNumBtn.Name = "OrderNumBtn";
            this.OrderNumBtn.Size = new System.Drawing.Size(190, 46);
            this.OrderNumBtn.TabIndex = 19;
            this.OrderNumBtn.Text = "Order Num";
            this.OrderNumBtn.TextChanged += new System.EventHandler(this.OrderNumBtn_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 190);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Food",
            "Cold Drink",
            "Coffee"});
            this.comboBox1.Location = new System.Drawing.Point(4, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 37);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Catagories";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DeepPink;
            this.button6.Location = new System.Drawing.Point(39, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(234, 48);
            this.button6.TabIndex = 24;
            this.button6.Text = "Item";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DeepPink;
            this.button7.Location = new System.Drawing.Point(39, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(234, 48);
            this.button7.TabIndex = 25;
            this.button7.Text = "Users";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DeepPink;
            this.button8.Location = new System.Drawing.Point(58, 709);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(234, 48);
            this.button8.TabIndex = 26;
            this.button8.Text = "LogOut";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1422, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 42);
            this.label6.TabIndex = 27;
            this.label6.Text = "X ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // UserOrder
            // 
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1469, 798);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrder";
            this.Load += new System.EventHandler(this.UserOrder_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PlaceOrderBtn;
        private System.Windows.Forms.TextBox QtyTB;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.DataGridView OrderGv;
        private System.Windows.Forms.Label OrderAmtLbl;
        private System.Windows.Forms.TextBox SellerNameTb;
        private System.Windows.Forms.TextBox OrderNumTB;
        private System.Windows.Forms.DataGridView ItemGV;
        private System.Windows.Forms.ComboBox CatCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toatl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PlaceOrder;
        private System.Windows.Forms.TextBox QT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddToCatBtn;
        private System.Windows.Forms.Label OrderAmtLb;
        private System.Windows.Forms.TextBox SellerNameBtn;
        private System.Windows.Forms.TextBox OrderNumBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Button button2;
    }
}