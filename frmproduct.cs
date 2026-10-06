using System;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    public partial class frmproduct : Form
    {
        public frmproduct()
        {
            InitializeComponent();
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {
            // Load Categories
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Food");
            comboBox1.Items.Add("Drinks");
            comboBox1.Items.Add("Grocery");
            comboBox1.Items.Add("Personal Care");
            comboBox1.Items.Add("Other");

            // DataGridView Settings
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCategory_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}