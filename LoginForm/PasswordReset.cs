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
    public partial class PasswordReset : UserControl
    {
        string cs = Environment.GetEnvironmentVariable("dbCon");
        public PasswordReset()
        {
            InitializeComponent();
        }

        private void PasswordReset_Load(object sender, EventArgs e)
        {
            
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cs);
            //frmLogin changePass = new frmLogin();
            //  string strCmd = "UPDATE Users SET Password='" + txtConfirmPassword.Text + "' WHERE Password='" + txtCurrentPassword.Text + "'";
            string strCmd = "UPDATE Users SET Password=@newPwd WHERE Password=@currPwd";
            if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    //string strCmd = "update Users set Password='" + txtConfirmPassword.Text + "' where Password='" + txtCurrentPassword.Text + "'";
                    cmd.Parameters.Add(new SqlParameter("@newPwd", HashEncryption.GenerateSHA512Hash(txtConfirmPassword.Text)));
                    cmd.Parameters.Add(new SqlParameter("@currPwd", HashEncryption.GenerateSHA512Hash(txtCurrentPassword.Text)));
                    cmd.CommandText = strCmd;

                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    this.Hide();
                    MessageBox.Show("Done successfully!");
                    LoginPage loginPage = new LoginPage();
                    loginPage.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Password do not match");
            }                
        }
    }
}
