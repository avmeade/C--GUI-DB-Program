using System;
using System.Windows.Forms;

namespace meade_milestone2
{
    public partial class pgInvSearch : Form
    {
        public pgInvSearch()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDBDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.pizzaDBDataSet.Inventory);
            // TODO: This line of code loads data into the 'pizzaDBDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.pizzaDBDataSet.Inventory);
            // TODO: This line of code loads data into the 'pizzaDBDataSet.orderitem' table. You can move, or remove it, as needed.
            this.orderitemTableAdapter.Fill(this.pizzaDBDataSet.orderitem);
            inventoryIDTextBox.Text = "Enter ID";
            productIDTextBox.Text = "Enter Product ID";
            inventoryQuantityTextBox.Text = "Enter Quantity";

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
            var invsearch = new pgInvSearch();
            invsearch.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var invdelete = new pgInvChange();
            invdelete.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // int inventoryid = Convert.ToInt32(inventory.Text);
            // this.inventoryTableAdapter.GetInventoryID(this.pizzaDBDataSet.order, inventoryid);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            int inventoryid = Convert.ToInt32(inventoryIDTextBox.Text);
            this.inventoryTableAdapter.GetInventoryID(this.pizzaDBDataSet.Inventory, inventoryid);
        }

        private void searchProductID_Click(object sender, EventArgs e)
        {

            int productid = Convert.ToInt32(productIDTextBox.Text);
            this.inventoryTableAdapter.GetProductID(this.pizzaDBDataSet.Inventory, productid);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int quantity = Convert.ToInt32(inventoryQuantityTextBox.Text);
            this.inventoryTableAdapter.GetProductID(this.pizzaDBDataSet.Inventory, quantity);
        }

        private void inventoryIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
