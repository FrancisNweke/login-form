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
    public partial class UserLogin : Form
    {
        static int attempt = 3;
        string cs = Environment.GetEnvironmentVariable("dbCon");
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
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
            else if (txtUsername.Text != "" && txtPassword.Text != "" && txtClientKey.Text != "")
            {
                try
                {
                    //string salt = HashEncryption.CreateSalt(10);
                    SqlConnection myConnection = default(SqlConnection);
                    myConnection = new SqlConnection(cs);

                    SqlCommand myCommand = default(SqlCommand);

                    myCommand = new SqlCommand("SELECT Username,Password,ClientKey FROM Users WHERE Username = @Username AND Password = @Password AND ClientKey = @ClientKey", myConnection);

                    SqlParameter uName = new SqlParameter("@Username", SqlDbType.NVarChar);
                    SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.NVarChar);
                    SqlParameter clientKey = new SqlParameter("@ClientKey", SqlDbType.NVarChar);

                    uName.Value = txtUsername.Text;
                    uPassword.Value = HashEncryption.GenerateSHA512Hash(txtPassword.Text);
                    clientKey.Value = txtClientKey.Text;

                    myCommand.Parameters.Add(uName);
                    myCommand.Parameters.Add(uPassword);
                    myCommand.Parameters.Add(clientKey);

                    myCommand.Connection.Open();

                    SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    if (myReader.Read() == true)
                    {
                        attempt = 0;
                        //Hide the login form
                        this.Hide();
                        MessageBox.Show("Login successful, " + txtUsername.Text);
                        Helper.CurrentUser = txtUsername.Text;
                        var couponGenerator = new CouponGenerator();
                        couponGenerator.ShowDialog();
                        return;
                    }
                    else if (attempt > 0 && myReader.Read() == false)
                    {
                        MessageBox.Show("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtClientKey.Clear();
                        --attempt;
                    }
                    else if (attempt == 0 && myReader.Read() == false)
                    {
                        MessageBox.Show("All 3 attempts failed", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                    }

                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();
                    }
                    return;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            panel1.BackColor = Color.LightBlue;
            txtUsername.ForeColor = Color.LightBlue;

            panel2.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            panel3.BackColor = Color.White;
            txtClientKey.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            panel2.BackColor = Color.LightBlue;
            txtPassword.ForeColor = Color.LightBlue;

            panel1.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            panel3.BackColor = Color.White;
            txtClientKey.ForeColor = Color.WhiteSmoke;
        }

        private void txtClientKey_Click(object sender, EventArgs e)
        {
            txtClientKey.Clear();
            panel3.BackColor = Color.LightBlue;
            txtClientKey.ForeColor = Color.LightBlue;

            panel1.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            panel2.BackColor = Color.White;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
