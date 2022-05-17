using System;
using System.Windows.Forms;

namespace meade_milestone2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
