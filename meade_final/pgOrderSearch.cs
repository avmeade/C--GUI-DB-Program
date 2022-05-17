using System;
using System.Windows.Forms;

namespace meade_milestone2
{
    public partial class pgOrderSearch : Form
    {
        public pgOrderSearch()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDBDataSet.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.pizzaDBDataSet.order);
            orderIDTextBox.Text = "Enter ID";
            customerIDTextBox.Text = "Enter Cus ID";
            totalTextBox.Text = "Enter Total";

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
            var ordersearch = new pgOrderSearch();
            ordersearch.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var orderdelete = new pgOrderChange();
            orderdelete.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int orderid = Convert.ToInt32(orderIDTextBox.Text);
            this.orderTableAdapter.GetID(this.pizzaDBDataSet.order, orderid);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int customerid = Convert.ToInt32(customerIDTextBox.Text);
            this.orderTableAdapter.GetCustomerID(this.pizzaDBDataSet.order, customerid);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            decimal total = Convert.ToDecimal(totalTextBox.Text);
            this.orderTableAdapter.GetTotal(this.pizzaDBDataSet.order, total);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
