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
    public partial class WelcomePage :  Form
    {
        string cs = Environment.GetEnvironmentVariable("dbCon");
        //String cs = @"Server=NWEKE-PC;Database=LoginAppDB;Trusted_Connection=false;MultipleActiveResultSets=true;User ID=sa;Password=admin@123#;Integrated Security=True; Connect Timeout=30";
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            
        }

        private void changePassword_Click_1(object sender, EventArgs e)
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
                    MessageBox.Show("Password do not match");            
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            this.lblCurrentUser.Text = Helper.CurrentUser;
            this.lblDate.Text = DateTime.Today.ToString("dddd, MMMM dd yyyy");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            this.Hide();
            MessageBox.Show("Logout successful", "Logout Allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LoginPage lp = new LoginPage();
            lp.ShowDialog();            
        }

        private void lblClientKey_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientKeyPage clientKeyPage = new ClientKeyPage();
            clientKeyPage.ShowDialog();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CouponGenerator couponGenerator = new CouponGenerator();
            couponGenerator.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
