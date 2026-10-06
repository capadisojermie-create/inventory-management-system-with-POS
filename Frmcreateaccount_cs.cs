using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS
{
    public partial class Frmcreateaccount_cs : Form
    {
        public readonly MySQL_Dataabase _db;

        public Frmcreateaccount_cs(MySQL_Dataabase db)
        {
            InitializeComponent();
            _db = db;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
        }

        private void textBox1_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide Password";
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
                checkBox1.Text = "Show Password";
            }
        }

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void panel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        // CLEAR BUTTON
        private void button2_Click(
            object sender,
            EventArgs e)
        {
            txtAccID.Clear();
            txtAccName.Clear();

            cbAccountType.SelectedIndex = -1;
            cbAccountType.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            textUsername.Clear();
            textPassword.Clear();

            txtAccID.Focus();
        }

        // CREATE ACCOUNT BUTTON
        private void button1_Click_1(
            object sender,
            EventArgs e)
        {
            // CHECK REQUIRED FIELDS
            if (string.IsNullOrWhiteSpace(txtAccID.Text) ||
                string.IsNullOrWhiteSpace(txtAccName.Text) ||
                string.IsNullOrWhiteSpace(cbAccountType.Text) ||
                string.IsNullOrWhiteSpace(textUsername.Text) ||
                string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                // OPEN DATABASE CONNECTION
                _db.ConnectToDataBase();

                // INSERT ACCOUNT
                string sql = @"
                    INSERT INTO tbl_account
                    (
                        acc_id,
                        acc_name,
                        acc_type,
                        user_name,
                        pass_word
                    )
                    VALUES
                    (
                        @acc_id,
                        @acc_name,
                        @acc_type,
                        @user_name,
                        @pass_word
                    )";

                using (MySqlCommand cmd =
                       new MySqlCommand(sql, _db.conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@acc_id",
                        txtAccID.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@acc_name",
                        txtAccName.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@acc_type",
                        cbAccountType.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@user_name",
                        textUsername.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@pass_word",
                        textPassword.Text.Trim()
                    );

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Account created successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // CLEAR FIELDS
                        txtAccID.Clear();
                        txtAccName.Clear();
                        cbAccountType.SelectedIndex = -1;
                        cbAccountType.Text = "";
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        textUsername.Clear();
                        textPassword.Clear();

                        // BALIK SA LOGIN FORM
                        var login = new frmLoginform();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Account was not created.",
                            "Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                _db.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database Error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                _db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                _db.CloseConnection();
            }
        }


        private void linkLabel1_LinkClicked_1(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            frmLoginform frmLogin = new frmLoginform();

            frmLogin.Show();

            this.Hide();
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Exit Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Thank you for using the Inventory Management System with POS. Goodbye!",
                    "Exit Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void b(object sender, EventArgs e)
        {

        }
    }
}