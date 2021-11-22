using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class NewUserControl : UserControl
    {
        string cs = Environment.GetEnvironmentVariable("dbCon");
        public NewUserControl()
        {
            InitializeComponent();
        }

        private void NewUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (txtClientKey.Text == "")
            {
                MessageBox.Show("Please enter clientkey", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientKey.Focus();
            }
            else if (txtUserName.Text != "" && txtPassword.Text != "" && txtClientKey.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"INSERT INTO Users(Username,Password,ClientKey) 
                                            VALUES(@Username,@Password,@ClientKey);";

                        cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@Password", HashEncryption.GenerateSHA512Hash(txtPassword.Text));
                        cmd.Parameters.AddWithValue("@ClientKey", txtClientKey.Text);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            Helper.NewUser = txtUserName.Text;

                            MessageBox.Show(txtUserName.Text + " created as user", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Application.Restart();
                            conn.Close();
                            //UserLogin userLogin = new UserLogin();
                            //userLogin.Show();
                            //userLogin.txtUsername.Text = Helper.NewUser;

                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }
                    }
                }
            }
        }
    }
}
