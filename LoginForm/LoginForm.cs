using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class LoginPage : Form
    {
        private Label label1;
        private Label label2;
        public TextBox txtUserName;
        public TextBox txtPassword;
        private Button btnLogin;
        private Label label3;
        private TextBox txtClientKey;
        private ToolTip toolTip1;
        private IContainer components;
        static int attempt = 3;
        private PictureBox pictureBox1;

        //string cs = @"Data Source=NWEKE-PC;Initial Catalog=LoginAppDB;Persist Security Info=True;User ID=sa;Password=***********;Integrated Security=True; Connect Timeout=30";
        string cs = Environment.GetEnvironmentVariable("dbCon");

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
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

                    uName.Value = txtUserName.Text;
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
                        MessageBox.Show("Login successful, " + txtUserName.Text);
                        Helper.CurrentUser = txtUserName.Text;
                        var couponGenerator = new CouponGenerator();
                        couponGenerator.ShowDialog();
                        return;
                    }
                    else if (attempt > 0 && myReader.Read() == false)
                    {
                        MessageBox.Show("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUserName.Clear();
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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientKey = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(307, 47);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(243, 24);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(307, 112);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(243, 25);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.Location = new System.Drawing.Point(511, 221);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(39, 30);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clientkey";
            // 
            // txtClientKey
            // 
            this.txtClientKey.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientKey.Location = new System.Drawing.Point(307, 172);
            this.txtClientKey.MaxLength = 50;
            this.txtClientKey.Multiline = true;
            this.txtClientKey.Name = "txtClientKey";
            this.txtClientKey.Size = new System.Drawing.Size(243, 25);
            this.txtClientKey.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Enter Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 277);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // LoginPage
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 255);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtClientKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //this.pictureBox1.Image = new Bitmap(@"C:\xampp\htdocs\StudentProjectSystem\img\home.jpg");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }
    }
}
