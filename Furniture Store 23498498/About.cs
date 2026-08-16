using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _23498498
{
    //=================================================================================
    // MT Orrie 23498498
    // Couch Potato Furniture Store
    // About Form
    //=================================================================================

    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        // Opens HomeForm from ToolStrip
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.ShowDialog();
        }

        // Opens CatalogueForm from ToolStrip
        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 catalogueForm = new Form2();
            catalogueForm.ShowDialog();
        }

        // Closes About form when Close button is clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
