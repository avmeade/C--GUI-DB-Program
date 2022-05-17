using System;
using System.Windows.Forms;

namespace meade_milestone2
{
    public partial class pgProductSearch : Form
    {
        public pgProductSearch()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDBDataSet1.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.pizzaDBDataSet1.product);
            // TODO: This line of code loads data into the 'pizzaDBDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.pizzaDBDataSet.product);
            productIDTextBox.Text = "Enter Product ID";
            productNameTextBox.Text = "Enter Product Name";
            productPriceTextBox.Text = "Enter Product Price";

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new pgMenu();
            menu.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            var order = new pgOrder();
            order.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inventory = new pgInv();
            inventory.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reports = new pgReport();
            reports.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var users = new pgUser();
            users.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            var products = new pgProduct();
            products.Show();
        }
        //this makes it so the window is able to be moved
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;



        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var productsearch = new pgProductSearch();
            productsearch.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var productdelete = new pgProductChange();
            productdelete.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(productIDTextBox.Text);
            this.productTableAdapter.GetProductID(this.pizzaDBDataSet.product, id);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string name = Convert.ToString(productNameTextBox.Text);
            this.productTableAdapter.GetName(this.pizzaDBDataSet.product, name);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            decimal price = Convert.ToDecimal(productPriceTextBox.Text);
            this.productTableAdapter.GetPrice(this.pizzaDBDataSet.product, price);
        }

        private void productIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
