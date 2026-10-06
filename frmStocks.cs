using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    public partial class frmStocks : Form
    {
        public frmStocks()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void frmStocks_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
    namespace inventory_management_system_with_POS
    {
        public partial class frmStocks : Form
        {
            // Search
            TextBox txtSearch;
            Button btnSearch;

            // Product Information
            TextBox txtProductID;
            TextBox txtProductName;
            ComboBox cmbCategory;
            TextBox txtCurrentStocks;

            TextBox txtBrand;
            TextBox txtUnitPrice;
            TextBox txtReorderLevel;
            TextBox txtTotalStockValue;

            // Buttons
            Button btnAdd;
            Button btnSave;
            Button btnDelete;
            Button btnUpdate;
            Button btnRestocks;
            Button btnViewHistory;

            // Table
            DataGridView dgvStockList;

            public frmStocks()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                this.Text = "frmStocks";
                this.Name = "frmStocks";
                this.StartPosition = FormStartPosition.CenterScreen;
                this.ClientSize = new Size(1135, 670);
                this.FormBorderStyle = FormBorderStyle.Sizable;

                // ==========================================
                // SEARCH LABEL
                // ==========================================

                Label lblSearch = new Label();
                lblSearch.Text = "Search:";
                lblSearch.Location = new Point(43, 76);
                lblSearch.Size = new Size(70, 25);
                lblSearch.Font = new Font("Segoe UI", 10F);

                // ==========================================
                // SEARCH TEXTBOX
                // ==========================================

                txtSearch = new TextBox();
                txtSearch.Name = "txtSearch";
                txtSearch.Location = new Point(123, 75);
                txtSearch.Size = new Size(583, 27);

                // ==========================================
                // SEARCH BUTTON
                // ==========================================

                btnSearch = new Button();
                btnSearch.Name = "btnSearch";
                btnSearch.Text = "Search";
                btnSearch.Location = new Point(728, 75);
                btnSearch.Size = new Size(90, 32);
                btnSearch.Click += btnSearch_Click;

                // ==========================================
                // PRODUCT ID
                // ==========================================

                Label lblProductID = new Label();
                lblProductID.Text = "Product ID:";
                lblProductID.Location = new Point(43, 147);
                lblProductID.Size = new Size(100, 25);
                lblProductID.Font = new Font("Segoe UI", 10F);

                txtProductID = new TextBox();
                txtProductID.Name = "txtProductID";
                txtProductID.Location = new Point(173, 136);
                txtProductID.Size = new Size(208, 27);

                // ==========================================
                // PRODUCT NAME
                // ==========================================

                Label lblProductName = new Label();
                lblProductName.Text = "Product Name:";
                lblProductName.Location = new Point(43, 193);
                lblProductName.Size = new Size(120, 25);
                lblProductName.Font = new Font("Segoe UI", 10F);

                txtProductName = new TextBox();
                txtProductName.Name = "txtProductName";
                txtProductName.Location = new Point(173, 182);
                txtProductName.Size = new Size(208, 27);

                // ==========================================
                // CATEGORY
                // ==========================================

                Label lblCategory = new Label();
                lblCategory.Text = "Category:";
                lblCategory.Location = new Point(43, 239);
                lblCategory.Size = new Size(100, 25);
                lblCategory.Font = new Font("Segoe UI", 10F);

                cmbCategory = new ComboBox();
                cmbCategory.Name = "cmbCategory";
                cmbCategory.Location = new Point(173, 230);
                cmbCategory.Size = new Size(208, 27);
                cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

                cmbCategory.Items.AddRange(new object[]
                {
                "Food",
                "Drinks",
                "Grocery",
                "Personal Care",
                "Other"
                });

                // ==========================================
                // CURRENT STOCKS
                // ==========================================

                Label lblCurrentStocks = new Label();
                lblCurrentStocks.Text = "Current Stocks:";
                lblCurrentStocks.Location = new Point(43, 292);
                lblCurrentStocks.Size = new Size(120, 25);
                lblCurrentStocks.Font = new Font("Segoe UI", 10F);

                txtCurrentStocks = new TextBox();
                txtCurrentStocks.Name = "txtCurrentStocks";
                txtCurrentStocks.Location = new Point(173, 281);
                txtCurrentStocks.Size = new Size(208, 27);

                // ==========================================
                // BRAND
                // ==========================================

                Label lblBrand = new Label();
                lblBrand.Text = "Brand:";
                lblBrand.Location = new Point(451, 147);
                lblBrand.Size = new Size(100, 25);
                lblBrand.Font = new Font("Segoe UI", 10F);

                txtBrand = new TextBox();
                txtBrand.Name = "txtBrand";
                txtBrand.Location = new Point(615, 137);
                txtBrand.Size = new Size(204, 27);

                // ==========================================
                // UNIT PRICE
                // ==========================================

                Label lblUnitPrice = new Label();
                lblUnitPrice.Text = "Unit Price:";
                lblUnitPrice.Location = new Point(451, 193);
                lblUnitPrice.Size = new Size(100, 25);
                lblUnitPrice.Font = new Font("Segoe UI", 10F);

                txtUnitPrice = new TextBox();
                txtUnitPrice.Name = "txtUnitPrice";
                txtUnitPrice.Location = new Point(615, 183);
                txtUnitPrice.Size = new Size(204, 27);

                // ==========================================
                // REORDER LEVEL
                // ==========================================

                Label lblReorderLevel = new Label();
                lblReorderLevel.Text = "Reorder Level:";
                lblReorderLevel.Location = new Point(451, 239);
                lblReorderLevel.Size = new Size(120, 25);
                lblReorderLevel.Font = new Font("Segoe UI", 10F);

                txtReorderLevel = new TextBox();
                txtReorderLevel.Name = "txtReorderLevel";
                txtReorderLevel.Location = new Point(615, 231);
                txtReorderLevel.Size = new Size(204, 27);

                // ==========================================
                // TOTAL STOCK VALUE
                // ==========================================

                Label lblTotalStockValue = new Label();
                lblTotalStockValue.Text = "Total Stock Value:";
                lblTotalStockValue.Location = new Point(451, 292);
                lblTotalStockValue.Size = new Size(150, 25);
                lblTotalStockValue.Font = new Font("Segoe UI", 10F);

                txtTotalStockValue = new TextBox();
                txtTotalStockValue.Name = "txtTotalStockValue";
                txtTotalStockValue.Location = new Point(615, 282);
                txtTotalStockValue.Size = new Size(204, 27);
                txtTotalStockValue.ReadOnly = true;

                // ==========================================
                // ADD BUTTON
                // ==========================================

                btnAdd = new Button();
                btnAdd.Name = "btnAdd";
                btnAdd.Text = "ADD";
                btnAdd.Location = new Point(44, 345);
                btnAdd.Size = new Size(114, 34);
                btnAdd.BackColor = Color.LightGreen;
                btnAdd.Click += btnAdd_Click;

                // ==========================================
                // SAVE BUTTON
                // ==========================================

                btnSave = new Button();
                btnSave.Name = "btnSave";
                btnSave.Text = "SAVE";
                btnSave.Location = new Point(174, 345);
                btnSave.Size = new Size(104, 34);
                btnSave.BackColor = Color.LightSteelBlue;
                btnSave.Click += btnSave_Click;

                // ==========================================
                // DELETE BUTTON
                // ==========================================

                btnDelete = new Button();
                btnDelete.Name = "btnDelete";
                btnDelete.Text = "DELETE";
                btnDelete.Location = new Point(289, 345);
                btnDelete.Size = new Size(91, 34);
                btnDelete.BackColor = Color.LightCoral;
                btnDelete.Click += btnDelete_Click;

                // ==========================================
                // UPDATE BUTTON
                // ==========================================

                btnUpdate = new Button();
                btnUpdate.Name = "btnUpdate";
                btnUpdate.Text = "UPDATE";
                btnUpdate.Location = new Point(398, 345);
                btnUpdate.Size = new Size(114, 34);
                btnUpdate.BackColor = Color.LightSteelBlue;
                btnUpdate.Click += btnUpdate_Click;

                // ==========================================
                // RESTOCKS BUTTON
                // ==========================================

                btnRestocks = new Button();
                btnRestocks.Name = "btnRestocks";
                btnRestocks.Text = "RESTOCKS";
                btnRestocks.Location = new Point(531, 345);
                btnRestocks.Size = new Size(120, 34);
                btnRestocks.BackColor = Color.LightSteelBlue;
                btnRestocks.Click += btnRestocks_Click;

                // ==========================================
                // VIEW HISTORY BUTTON
                // ==========================================

                btnViewHistory = new Button();
                btnViewHistory.Name = "btnViewHistory";
                btnViewHistory.Text = "VIEW HISTORY";
                btnViewHistory.Location = new Point(669, 345);
                btnViewHistory.Size = new Size(150, 34);
                btnViewHistory.BackColor = Color.LightSteelBlue;
                btnViewHistory.Click += btnViewHistory_Click;

                // ==========================================
                // STOCK LIST LABEL
                // ==========================================

                Label lblStockList = new Label();
                lblStockList.Text = "Stock List";
                lblStockList.Location = new Point(48, 416);
                lblStockList.Size = new Size(100, 25);
                lblStockList.Font = new Font("Segoe UI", 10F);

                // ==========================================
                // DATAGRIDVIEW
                // ==========================================

                dgvStockList = new DataGridView();
                dgvStockList.Name = "dgvStockList";
                dgvStockList.Location = new Point(43, 436);
                dgvStockList.Size = new Size(905, 198);

                dgvStockList.AllowUserToAddRows = true;
                dgvStockList.AllowUserToDeleteRows = false;
                dgvStockList.AllowUserToResizeRows = false;

                dgvStockList.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.None;

                dgvStockList.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvStockList.MultiSelect = false;
                dgvStockList.ReadOnly = false;

                dgvStockList.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // ==========================================
                // COLUMNS
                // ==========================================

                dgvStockList.Columns.Add("ID", "ID");
                dgvStockList.Columns.Add("ProductName", "Product Name");
                dgvStockList.Columns.Add("Category", "Category");
                dgvStockList.Columns.Add("Brand", "Brand");
                dgvStockList.Columns.Add("UnitPrice", "Unit Price");
                dgvStockList.Columns.Add("CurrentStock", "Current Stock");
                dgvStockList.Columns.Add("ReorderLevel", "Reorder Level");
                dgvStockList.Columns.Add("TotalStockValue", "Total Stock Value");

                dgvStockList.Columns["ID"].Width = 73;
                dgvStockList.Columns["ProductName"].Width = 73;
                dgvStockList.Columns["Category"].Width = 105;
                dgvStockList.Columns["Brand"].Width = 83;
                dgvStockList.Columns["UnitPrice"].Width = 103;
                dgvStockList.Columns["CurrentStock"].Width = 129;
                dgvStockList.Columns["ReorderLevel"].Width = 130;
                dgvStockList.Columns["TotalStockValue"].Width = 155;

                // ==========================================
                // ADD CONTROLS TO FORM
                // ==========================================

                this.Controls.Add(lblSearch);
                this.Controls.Add(txtSearch);
                this.Controls.Add(btnSearch);

                this.Controls.Add(lblProductID);
                this.Controls.Add(txtProductID);

                this.Controls.Add(lblProductName);
                this.Controls.Add(txtProductName);

                this.Controls.Add(lblCategory);
                this.Controls.Add(cmbCategory);

                this.Controls.Add(lblCurrentStocks);
                this.Controls.Add(txtCurrentStocks);

                this.Controls.Add(lblBrand);
                this.Controls.Add(txtBrand);

                this.Controls.Add(lblUnitPrice);
                this.Controls.Add(txtUnitPrice);

                this.Controls.Add(lblReorderLevel);
                this.Controls.Add(txtReorderLevel);

                this.Controls.Add(lblTotalStockValue);
                this.Controls.Add(txtTotalStockValue);

                this.Controls.Add(btnAdd);
                this.Controls.Add(btnSave);
                this.Controls.Add(btnDelete);
                this.Controls.Add(btnUpdate);
                this.Controls.Add(btnRestocks);
                this.Controls.Add(btnViewHistory);

                this.Controls.Add(lblStockList);
                this.Controls.Add(dgvStockList);
            }

            // ==========================================
            // BUTTON EVENTS
            // ==========================================

            private void btnSearch_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Search button clicked.");
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                txtProductID.Clear();
                txtProductName.Clear();
                txtBrand.Clear();
                txtUnitPrice.Clear();
                txtCurrentStocks.Clear();
                txtReorderLevel.Clear();
                txtTotalStockValue.Clear();
                cmbCategory.SelectedIndex = -1;

                txtProductName.Focus();
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Stock saved successfully.");
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (dgvStockList.CurrentRow != null &&
                    !dgvStockList.CurrentRow.IsNewRow)
                {
                    dgvStockList.Rows.RemoveAt(
                        dgvStockList.CurrentRow.Index);
                }
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Stock updated successfully.");
            }

            private void btnRestocks_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Restocks button clicked.");
            }

            private void btnViewHistory_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Stock history button clicked.");
            }
        }
    }
}
