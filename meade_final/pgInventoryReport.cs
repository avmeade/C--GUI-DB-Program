using System;
using System.Windows.Forms;

namespace meade_milestone2
{
    public partial class pgInventoryReport : Form
    {
        public pgInventoryReport()
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

        private void btnClosedReport_Click(object sender, EventArgs e)
        {
            this.Close();
            var orderReport = new pgOrderReport();
            orderReport.Show();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDBDataSet);

        }



        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pizzaDBDataSet.EnforceConstraints = false;
            this.inventoryTableAdapter.ShowLargerThan(this.pizzaDBDataSet.Inventory);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pizzaDBDataSet.EnforceConstraints = false;
            this.inventoryTableAdapter.GetLessThan(this.pizzaDBDataSet.Inventory);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pizzaDBDataSet.EnforceConstraints = false;
            this.inventoryTableAdapter.GetStock(this.pizzaDBDataSet.Inventory);
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            this.Close();
            var invReport = new pgInventoryReport();
            invReport.Show();
        }
    }
}
