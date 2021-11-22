using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginForm
{
    public partial class CouponGeneratorControlForm : UserControl
    {
        string id, showId, printId;
        DateTime n = DateTime.Now;
        FileStream file;
        public CouponGeneratorControlForm()
        {
            InitializeComponent();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void CouponGeneratorControlForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            id = Guid.NewGuid().ToString();
            showId = (id + "-nef, " + "\n@ " + n);
            printId = (id + "-nef, " + "@ " + n);
            this.labelCoupon.Text = showId;
            DialogResult dialogResult = MessageBox.Show("Coupon generated.. Export as a text file?", "Coupon Generator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    file = new FileStream(@"C:\Users\nweke\Documents\Visual Studio 2017\Projects\UniqueNumberGenerator\Generated Keys\GeneratedKeys.txt", FileMode.Append, FileAccess.Write);
                    TextWriter textWriter = new StreamWriter(file);
                    //TextWriter textWriter = new StreamWriter(@"C:\Users\nweke\Documents\Visual Studio 2017\Projects\UniqueNumberGenerator\Generated Keys\GeneratedKeys.txt");
                    //streamWriter.Write("\n"+showId+"\n");
                    //streamWriter.Close();
                    textWriter.Write(Environment.NewLine + printId);
                    textWriter.Close();
                    MessageBox.Show("Coupon exported", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Cannot open file for writing");
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
