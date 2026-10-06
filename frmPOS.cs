using System;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    public partial class FrmSales : Form
    {
        private Timer timer;

        public FrmSales()
        {
            InitializeComponent();

            // Connect Form Load event
            this.Load += FrmSales_Load;
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            // =========================
            // DISPLAY DATE & TIME
            // =========================

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Show date and time immediately
            UpdateDateTime();

            // =========================
            // NET TOTAL
            // =========================

            UpdateNetTotal();

            // Update Net Total when rows change
            dataGridView1.RowsAdded += DataGridView1_RowsChanged;
            dataGridView1.RowsRemoved += DataGridView1_RowsChanged;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        // =========================
        // TIMER
        // =========================

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        // =========================
        // DISPLAY DATE & TIME
        // =========================

        private void UpdateDateTime()
        {
            // Display Date
            label9.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            // Display Time
            label10.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        // =========================
        // NET TOTAL
        // =========================

        private void UpdateNetTotal()
        {
            decimal netTotal = 0;

            // Make sure DataGridView has columns
            if (dataGridView1.ColumnCount == 0)
            {
                label8.Text = "₱0.00";
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip empty/new row
                if (row.IsNewRow)
                    continue;

                decimal total = 0;

                // =====================================
                // IMPORTANT:
                // Change 4 if your TOTAL column is
                // located in another position.
                //
                // 0 = Column 1
                // 1 = Column 2
                // 2 = Column 3
                // 3 = Column 4
                // 4 = Column 5
                // =====================================

                if (row.Cells.Count > 4)
                {
                    object value = row.Cells[4].Value;

                    if (value != null)
                    {
                        decimal.TryParse(
                            value.ToString(),
                            out total
                        );
                    }
                }

                netTotal += total;
            }

            // Display Net Total
            label8.Text = "₱" + netTotal.ToString("N2");
        }

        // =========================
        // UPDATE NET TOTAL
        // =========================

        private void DataGridView1_RowsChanged(
            object sender,
            DataGridViewRowsAddedEventArgs e)
        {
            UpdateNetTotal();
        }

        private void DataGridView1_RowsChanged(
            object sender,
            DataGridViewRowsRemovedEventArgs e)
        {
            UpdateNetTotal();
        }

        private void DataGridView1_CellValueChanged(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateNetTotal();
            }
        }

        // =========================
        // FORM CLOSE
        // =========================

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }

            base.OnFormClosed(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}