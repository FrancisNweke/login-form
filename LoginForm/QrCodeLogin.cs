using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace LoginForm
{
    public partial class QrCodeLogin : Form
    {
        public QrCodeLogin()
        {
            InitializeComponent();
        }

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;

        public string textcode
        {
            get { return this.txtDecodedCode.Text; }
            set { this.txtDecodedCode.Text = value; }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QrCodeLogin_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            //FinalFrame = new VideoCaptureDevice();
        }

        private void QrCodeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning == true)
            {
                captureDevice.Stop();
            }
        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += FinalFrame_NewFrame;
            captureDevice.Start();
            btnWebCam.Enabled = false;
            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnCheck.Enabled = false;
            txtDecodedCode.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    string decoded = result.ToString();
                    txtDecodedCode.Text = decoded;
                    timer1.Stop();
                    if (captureDevice.IsRunning == true)
                    {
                        btnCheck.Enabled = true;
                        MessageBox.Show("Welcome");
                        captureDevice.Stop();
                        //CouponGenerator couponGenerator = new CouponGenerator();
                        //couponGenerator.ShowDialog();
                    }
                }
            }            
        }
    }
}
