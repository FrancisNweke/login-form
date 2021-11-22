using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class NewUser : Form
    {
        string cs = Environment.GetEnvironmentVariable("dbCon");
        //string salt = HashEncryption.CreateSalt(10);

        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            //this.pictureBox1.Image = new Bitmap(@"C:\Users\nweke\Downloads\User2.png");
            this.lblDate.Text = DateTime.Today.ToString("dddd, MMMM dd yyyy");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            CouponGenerator couponGenerator = new CouponGenerator();
            couponGenerator.Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
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

                            CouponGenerator couponGenerator = new CouponGenerator();
                            couponGenerator.Close();

                            MessageBox.Show(txtUserName.Text + " created as user", "New User", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Hide();

                            LoginPage loginPage = new LoginPage();
                            loginPage.txtUserName.Text = Helper.NewUser;
                            //HashEncryption.GenerateSHA512Hash(loginPage.txtPassword.Text);
                            loginPage.ShowDialog();
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

