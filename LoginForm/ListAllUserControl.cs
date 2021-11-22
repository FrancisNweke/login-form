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
    public partial class ListAllUserControl : UserControl
    {
        string cs = Environment.GetEnvironmentVariable("dbCon");
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public ListAllUserControl()
        {
            InitializeComponent();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT Username, ClientKey FROM Users";
                dr = cmd.ExecuteReader();

                listView1.View = View.Details;

                listView1.Columns.Add("Username", 150, HorizontalAlignment.Center);
                listView1.Columns.Add("Clientkey", 280, HorizontalAlignment.Center);

                while (dr.Read())
                {
                    var item = new ListViewItem();
                    item.Text = dr["Username"].ToString();        // 1st column text
                    item.SubItems.Add(dr["Clientkey"].ToString());  // 2nd column text
                    listView1.Items.Add(item);
                }
            }
            finally
            {
                cmd.Connection.Close();
            }         
        }

        private void ListAllUserControl_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = false;          
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string strCmd = "DELETE FROM Users WHERE Username = @Username AND ClientKey = @Clientkey";

            string usernameInput =
                            Microsoft.VisualBasic.Interaction.InputBox("Enter Username: ",
                                                               "User to be deleted",
                                                               "",
                                                               -1, -1);
            string clientkeyInput =
                            Microsoft.VisualBasic.Interaction.InputBox("Enter Clientkey: ",
                                                               "Specify clientkey",
                                                               "",
                                                               -1, -1);
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand(strCmd, con);

                cmd.Parameters.AddWithValue("@Username", usernameInput);
                cmd.Parameters.AddWithValue("@Clientkey", clientkeyInput);
                cmd.CommandType = CommandType.Text;
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(string.Format("{0} removed as a user.", usernameInput), "DB Connection With App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listView1.Clear();
                btnUserList.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
