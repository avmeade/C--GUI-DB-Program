using System;
using System.Windows.Forms;

namespace meade_milestone2
{
    public partial class pgUserSearch : Form
    {
        public pgUserSearch()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDBDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.pizzaDBDataSet.user);
            userIDTextBox.Text = "Enter ID";
            userNameTextBox.Text = "Enter User Name";
            userAddressTextBox.Text = "Enter User Address";
            userZipTextBox.Text = "Enter User Zipcode";
            userCityTextBox.Text = "Enter User City";
            userStateTextBox.Text = "Enter User State";
            userEmailTextBox.Text = "Enter User Email";

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



        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            this.Close();
            var searchuser = new pgUserSearch();
            searchuser.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            this.Close();
            var deleteuser = new pgUserChange();
            deleteuser.Show();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pizzaDBDataSet);

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void userAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void userZipLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(userIDTextBox.Text);
            this.userTableAdapter.GetUserID(this.pizzaDBDataSet.user, id);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.userTableAdapter.GetName(this.pizzaDBDataSet.user, userNameTextBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.userTableAdapter.GetAddress(this.pizzaDBDataSet.user, userAddressTextBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.userTableAdapter.GetZip(this.pizzaDBDataSet.user, userZipTextBox.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.userTableAdapter.GetCity(this.pizzaDBDataSet.user, userCityTextBox.Text);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            this.userTableAdapter.GetState(this.pizzaDBDataSet.user, userStateTextBox.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.userTableAdapter.GetEmail(this.pizzaDBDataSet.user, userEmailTextBox.Text);

        }
    }
}
