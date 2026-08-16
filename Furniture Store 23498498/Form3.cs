using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace _23498498
{
    //=================================================================================
    // MT Orrie 23498498
    // Couch Potato Furniture Store
    // Form 3 - Invoice and Customer Details
    //=================================================================================

    public partial class Form3 : Form
    {
        private string[] selectedFurnitureItems;
        private string deliveryOption;
        private string paymentMethod;
        private string totalAmount;
        private string deliveryDate;

        public Form3(
             string[] checkboxItems,
             string radioButtonItems,
             string comboboxItems,
             string totalItem,
             string dateselectedItem)
        {
            InitializeComponent();

            selectedFurnitureItems = checkboxItems;
            deliveryOption = radioButtonItems;
            paymentMethod = comboboxItems;
            totalAmount = totalItem;
            deliveryDate = dateselectedItem;
        }

        // Opens AboutForm from ToolStrip
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        // Opens HomeForm from ToolStrip
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
        }

        // Opens CatalogueForm from ToolStrip
        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 catalogueForm = new Form2();
            catalogueForm.Show();
        }

        // Loads invoice with selections from Form2
        private void Form3_Load(object sender, EventArgs e)
        {
            txtInvoice.Clear();

            txtInvoice.AppendText("SELECTED ORDER");
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText("======================================");
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText(Environment.NewLine);
      
            // Display Furniture
            foreach (string item in selectedFurnitureItems)
            {
                txtInvoice.AppendText(item);
                txtInvoice.AppendText(Environment.NewLine);
            }

            txtInvoice.AppendText(Environment.NewLine);

            // Display Delivery
            txtInvoice.AppendText("Delivery Option: ");
            txtInvoice.AppendText(deliveryOption);
            txtInvoice.AppendText(Environment.NewLine);

            // Display Payment Method
            txtInvoice.AppendText("Payment Method: ");
            txtInvoice.AppendText(paymentMethod);
            txtInvoice.AppendText(Environment.NewLine);

            // Display Delivery Date
            txtInvoice.AppendText("Delivery Date: ");
            txtInvoice.AppendText(deliveryDate);
            txtInvoice.AppendText(Environment.NewLine);

            // Display Totals
            txtInvoice.AppendText("Total Amount: ");
            txtInvoice.AppendText(totalAmount);

            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText(
                "Please complete your customer details then click VALIDATE.");
        }

        // Validation Button
        private void btnValidate_Click(object sender, EventArgs e)
        {
            Regex nameRegex =
                new Regex(@"^[A-Za-z\s]+$");

            Regex emailRegex =
                new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            Regex phoneRegex =
                new Regex(@"^0\d{9}$");

            Regex idRegex =
                new Regex(@"^\d{13}$");

            // Name Validation
            if (!nameRegex.IsMatch(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter a valid name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtName.Focus();
                return;
            }

            // Email Validation
            if (!emailRegex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtEmail.Focus();
                return;
            }

            // Phone Validation
            if (!phoneRegex.IsMatch(txtPhone.Text))
            {
                MessageBox.Show(
                    "Please enter a valid telephone number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                txtPhone.Focus();
                return;
            }

            // ID Validation
            if (!idRegex.IsMatch(txtID.Text))
            {
                MessageBox.Show(
                    "Please enter a valid South African ID Number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtID.Focus();
                return;
            }

            // Luhn Validation
            if (!IsValidLuhn(txtID.Text))
            {
                MessageBox.Show(
                "Invalid South African ID Number.",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                txtID.Focus();
                return;
            }

            GenerateInvoice();
            
        }

        // Generates the invoice with customer details and order information
        private void GenerateInvoice()
        {
            Random rnd = new Random();

            string invoiceNumber = "CP" + rnd.Next(10000, 99999);

            txtInvoice.Clear();

            txtInvoice.AppendText("========================================");
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText("        COUCH POTATO FURNITURE");
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText("========================================");
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Invoice Number : " + invoiceNumber);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Invoice Date : " + DateTime.Now.ToShortDateString());
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("CUSTOMER DETAILS");
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText("----------------------------------------");
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Customer Name : " + txtName.Text);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Email Address : " + txtEmail.Text);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Telephone : " + txtPhone.Text);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("ID Number : " + txtID.Text);
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("ORDER DETAILS");
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText("----------------------------------------");
            txtInvoice.AppendText(Environment.NewLine);

            foreach (string item in selectedFurnitureItems)
            {
                txtInvoice.AppendText(item);
                txtInvoice.AppendText(Environment.NewLine);
            }

            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Delivery Option : " + deliveryOption);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Payment Method : " + paymentMethod);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Delivery Date : " + deliveryDate);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Total Amount : " + totalAmount);
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText(Environment.NewLine);

            txtInvoice.AppendText("Thank you for supporting sustainable living!");
            txtInvoice.AppendText(Environment.NewLine);
            txtInvoice.AppendText("Thank you for shopping with Couch Potato!");

            // Save invoices to text file
            File.AppendAllText(
                "Invoices.txt",
                txtInvoice.Text +
                Environment.NewLine +
                "======================================================" +
                Environment.NewLine +
                Environment.NewLine);
        }

        // Luhn Algorithm
        private bool IsValidLuhn(string id)
        {
            int sum = 0;
            bool alternate = false;

            for (int i = id.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(id[i].ToString());

                if (alternate)
                {
                    n *= 2;

                    if (n > 9)
                    {
                        n = (n % 10) + 1;
                    }
                }

                sum += n;
                alternate = !alternate;
            }

            return (sum % 10 == 0);
        }



        // Clears customer details and invoice
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtID.Clear();
            txtInvoice.Clear();

            txtName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}