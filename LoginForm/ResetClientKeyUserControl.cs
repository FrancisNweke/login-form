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
    public partial class ResetClientKeyUserControl : UserControl
    {
        string cs = Environment.GetEnvironmentVariable("dbCon");
        public ResetClientKeyUserControl()
        {
            InitializeComponent();
        }

        private void ResetClientKeyUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtOldClientKey.Focus();
            if (txtOldClientKey.Text == "")
            {
                MessageBox.Show("Please enter old client key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldClientKey.Focus();
            }
            else if (txtNewClientKey.Text == "")
            {
                MessageBox.Show("Please enter new client key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewClientKey.Focus();
            }
            else if (txtOldClientKey.Text == txtNewClientKey.Text)
            {
                MessageBox.Show("Old Client Key and New Client Key must not match!");
                txtNewClientKey.Clear();
                txtNewClientKey.Focus();
            }
            else if (txtNewClientKey.Text != "" && txtOldClientKey.Text != "")
            {
                try
                {

                    SqlConnection myConnection = default(SqlConnection);
                    myConnection = new SqlConnection(cs);

                    SqlCommand myCommand = default(SqlCommand);

                    myCommand = new SqlCommand("UPDATE Users SET ClientKey=@NewClientKey WHERE ClientKey=@OldClientKey", myConnection);

                    myCommand.Parameters.AddWithValue("@NewClientKey", txtNewClientKey.Text.ToString());
                    myCommand.Parameters.AddWithValue("@OldClientKey", txtOldClientKey.Text.ToString());

                    myCommand.Connection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    this.Hide();
                    MessageBox.Show("Client Key Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var loginPage = new LoginPage();
                    loginPage.ShowDialog();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
