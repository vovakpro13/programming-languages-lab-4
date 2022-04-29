using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;
using System.Configuration;
using System.Security.Cryptography;

namespace lab_1
{
    public partial class LogIn : Form
    {
        public string[,] matrix;
        DataTable dt;

        public LogIn()
        {
            InitializeComponent();

            string SERVER_IP = ConfigurationSettings.AppSettings["SERVER_IP"];
            string SERVER_USERNAME = ConfigurationSettings.AppSettings["SERVER_USERNAME"];
            string SERVER_PASSWORD = ConfigurationSettings.AppSettings["SERVER_PASSWORD"];

            DB.ConStr = "server = " + SERVER_IP + "; characterset = utf-8;" +
                "user = " + SERVER_USERNAME + "; database = " + SERVER_USERNAME +
                "; password = " + SERVER_PASSWORD;

            dt = DB.myDataTable("SELECT * FROM app_users");
            int count = dt.Rows.Count;

            matrix = new string[count, 4];

            for (int i = 0; i < count; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("id").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("username").ToString();
                matrix[i, 2] = dt.Rows[i].Field<int>("type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("password").ToString();

                cbxUser.Items.Add(matrix[i, 1]);
            }

            cbxUser.Text = matrix[0, 1];
            txtPassword.UseSystemPasswordChar = true;
            cbxUser.Focus();
        }

        public void Authorization()
        {
            bool flUser = false;
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (String.Equals(cbxUser.Text.ToUpper(), matrix[i, 1].ToUpper()))
                    {
                        flUser = true;

                        if (String.Equals(DB.EncriptedPassword(txtPassword.Text), matrix[i, 3]))
                        {
                            DB.nameUser = matrix[i, 1];
                            DB.typeUser = matrix[i, 2];

                            cbxUser.Text = "";
                            txtPassword.Text = "";

                            this.Hide();

                            mainForm form = new mainForm();
                            form.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Enter correct password!", "Authorization Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Text = "";
                            txtPassword.Focus();
                        }
                    }
                }
            }

            if (!flUser)
            {
                MessageBox.Show("User '" + cbxUser.Text + "' is not registered in the system!" +
                    "\nReport to an administrator...", "Authorization Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxUser.Text = "";
                cbxUser.Focus();
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Authorization();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Authorization();
            } else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Authorization();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btnOk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
            
        }
    }

    static class DB
    {
        public static string ConStr { get; set; }
        public static string typeUser { get; set; }
        public static string nameUser { get; set; }
        public static BindingSource bs1 { get; set; }

        public static DataTable myDataTable(string commandString)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(DB.ConStr))
            {
                MySqlCommand command = new MySqlCommand(commandString, connection);

                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot access to the SQL Server!\nCheck your internet connection.",
                       "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        public static string EncriptedPassword(string s)
        {
            if (string.Compare(s, "null", true) == 0)
                return "NULL";

            byte[] bytes = Encoding.Unicode.GetBytes(s);

            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHach = CSP.ComputeHash(bytes);
            string hash = string.Empty;

            foreach (byte b in byteHach)
                hash += String.Format("{0:x2}", b);

            return hash;
        }

    }
}
