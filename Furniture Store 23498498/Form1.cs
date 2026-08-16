using static System.Windows.Forms.DataFormats;

namespace _23498498
{
    //=================================================================================
    // MT Orrie 23498498
    // Couch Potato Furniture Store
    // Form 1 - Home Screen
    //=================================================================================

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Opens AboutForm from ToolStrip
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        // Opens CatalogueForm from ToolStrip
        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 catalogueForm = new Form2();
            catalogueForm.Show();
        }
    }
}
