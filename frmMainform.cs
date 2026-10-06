using System;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    public partial class frmMainform : Form
    {
        private readonly MySQL_Dataabase _db;
        private Form _currentChild;

        public frmMainform() : this(null)
        {
        }

        public frmMainform(MySQL_Dataabase db)
        {
            InitializeComponent();
            _db = db;
        }

        private void frmMainform_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        // ==========================================
        // Loads any form inside panel2 as a child form
        // ==========================================
        private void OpenChildForm(Form child)
        {
            if (_currentChild != null)
            {
                _currentChild.Close();
                _currentChild.Dispose();
            }

            _currentChild = child;

            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(child);

            child.Show();
            child.BringToFront();
        }

        private void ShowDashboard()
        {
            OpenChildForm(new frmDashboard());
        }

        private void timer1_Tick(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void toolStripButton1_Click(object sender, EventArgs e)   // Dashboard
        {
            ShowDashboard();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)   // Home
        {
            ShowDashboard();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)   // Point of Sale
        {
            OpenChildForm(new FrmSales());
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OpenChildForm(new frmproduct());
        }

        private void manageStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStocks());
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)   // Report
        {
            // OpenChildForm(new frmReport(_db));
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e) { }   // Setting

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount account = new frmAccount(_db);
            account.ShowDialog();
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}