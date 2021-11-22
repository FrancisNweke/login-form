using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class CouponGenerator : Form
    {
        string id, showId;
        DateTime n = DateTime.Now;
        FileStream file;
        //StreamWriter streamWriter;
        //TextWriter textWriter;
        
        public CouponGenerator()
        {
            InitializeComponent();
            
            // .Now.ToString("dddd, MMM dd yyyy, HH:mm:ss");
            //lblUserLogged.Text = loginPage.UserName;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CouponGenerator_Load(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Today.ToString("dddd, MMMM dd yyyy.");
            this.lblCurrentUser.Text = Helper.CurrentUser;
            couponGeneratorControlForm1.BringToFront();
            couponGeneratorControlForm1.Dock = DockStyle.Fill;
            if (lblCurrentUser.Text != "admin")
            {
                createNewUserToolStripMenuItem.Enabled = false;
                viewAllUsersToolStripMenuItem.Enabled = false;
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            
        }

        //Go back to Client Key Page
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //WelcomePage welcomePage = new WelcomePage();
            //welcomePage.ShowDialog();
        }

        private void btnResetClientKey_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //var clientKeyPage = new ClientKeyPage();
            //clientKeyPage.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //NewUser newUser = new NewUser();
            //newUser.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            Application.Exit();
            MessageBox.Show("Logout successful", "Logout Allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newUserControl1.BringToFront();
            newUserControl1.Dock = DockStyle.Fill;
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordReset1.BringToFront();
            passwordReset1.Dock = DockStyle.Fill;
        }

        private void resetClientKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetClientKeyUserControl1.BringToFront();
            resetClientKeyUserControl1.Dock = DockStyle.Fill;
        }

        private void couponGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            couponGeneratorControlForm1.BringToFront();
            couponGeneratorControlForm1.Dock = DockStyle.Fill;
        }

        private void couponGeneratorControlForm1_Load(object sender, EventArgs e)
        {

        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listAllUserControl1.BringToFront();
            listAllUserControl1.Dock = DockStyle.Fill;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            } else
            {
                timer1.Stop();
                Application.Exit();
            }            
        }
    }
}
