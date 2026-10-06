using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace inventory_management_system_with_POS {
    public class MySQL_Dataabase {
        public MySqlConnection conn = new MySqlConnection();
        public MySqlCommand cmd;
        public MySqlDataReader dr;

        public void ConnectToDataBase()
        {
            try
            {
                string str = "Server=localhost;Database=inventory_system;User ID=root;Password=123456789;";

                conn.ConnectionString = str;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                //if (conn.State == ConnectionState.Open)
                //{
                //    MessageBox.Show(
                //        "Database connection successful",
                //        "Success",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Information
                //    );
                //}
                //else
                //{
                //    MessageBox.Show(
                //        "Database connection failed!",
                //        "Error",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Error
                //    );
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}