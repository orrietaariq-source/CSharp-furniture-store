using System;
using System.Windows.Forms;

namespace _23498498
{
    //=================================================================================
    // MT Orrie 23498498
    // Couch Potato Furniture Store
    // Form 2 - Furniture Catalogue
    //=================================================================================

    public partial class Form2 : Form
    {

        public string radioButtonItems;
        public string comboboxItems;
        public string totalItem;
        public string dateselectedItem;

        public string[] checkboxItems;

        public Form2()
        {
            InitializeComponent();

            // Catalogue setting
            checkedListBox1.CheckOnClick = true;

            // Calendar setting - does not allow previous dates
            monthCalendar1.MinDate = DateTime.Today;

            // Default payment method already there
            comboBox1.SelectedIndex = 0;

            // Default delivery option
            radioButton1.Checked = true;

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

        // Calendar date change
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }


        // Calculates total cost based on selected furniture items and delivery option, then opens Form3 to display the invoice
        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            string selectedItems = "";

            // Checks if a delivery date has been selected
            if (monthCalendar1.SelectionStart == DateTime.Today)
            {
                MessageBox.Show(
                    "Please select a delivery date before continuing.",
                    "Delivery Date Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            
            // Stores required values for Form 3
            dateselectedItem =
               monthCalendar1.SelectionStart.ToShortDateString();

            comboboxItems =
                comboBox1.Text;

            // Select delivery options
            if (radioButton1.Checked)
            {
                radioButtonItems = radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                radioButtonItems = radioButton2.Text;
                total += 150;
            }

            if (radioButton3.Checked)
            {
                radioButtonItems = radioButton3.Text;
                total += 500;
            }

            if (radioButton4.Checked)
            {
                radioButtonItems = radioButton4.Text;
                total += 300;
            }

            // Stores funiture items selected
            checkboxItems = new string[checkedListBox1.CheckedItems.Count];

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                checkboxItems[i] =
                    checkedListBox1.CheckedItems[i].ToString();

                selectedItems +=
                    checkboxItems[i] +
                    Environment.NewLine;
            }

            // List furniture items to select
            foreach (string item in checkedListBox1.CheckedItems)
            {
                if (item.Contains("900"))
                    total += 900;

                if (item.Contains("1500"))
                    total += 1500;

                if (item.Contains("800"))
                    total += 800;

                if (item.Contains("550"))
                    total += 550;

                if (item.Contains("2200"))
                    total += 2200;

                if (item.Contains("700"))
                    total += 700;

                if (item.Contains("2000"))
                    total += 2000;

                if (item.Contains("500"))
                    total += 500;

                if (item.Contains("1100"))
                    total += 1100;

                if (item.Contains("1200"))
                    total += 1200;

                if (item.Contains("1850"))
                    total += 1850;
            }

            // Adds selected delivery to invoice
            selectedItems += Environment.NewLine;
            selectedItems += "Delivery Option: " + radioButtonItems;

            // Displays totals
            totalItem = "Total : R" + total.ToString();
            txtTotal.Text = totalItem;

            // Opens Form3 with all info 
            Form3 invoiceForm = new Form3(
                checkboxItems,
                radioButtonItems,
                comboboxItems,
                totalItem,
                dateselectedItem);

            invoiceForm.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}