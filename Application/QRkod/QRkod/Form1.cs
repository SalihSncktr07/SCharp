using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace QRkod
{
    public partial class Form1 : Form
    {
        FilterInfoCollection webcam;
        VideoCaptureDevice cam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in webcam)
            {
                comboBox1.Items.Add(dev.Name);
            }
            comboBox1.SelectedIndex = 0;
        }
        private void cam_NewCam(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = ((Bitmap)eventArgs.Frame.Clone());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewCam);
            cam.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barkod = new BarcodeReader();
            if (pictureBox1.Image != null)
            {
                Result res = barkod.Decode((Bitmap)pictureBox1.Image);
                try
                {
                    string dec = res.ToString().Trim();
                    if(dec != "")
                    {
                        timer1.Stop();
                        textBox1.Text = dec;
                    }
                }
                catch (Exception ex)
                {
                     
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
            {
                if(cam.IsRunning == true)
                {
                    cam.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 ekle = new Form2();
            ekle.Show();
            this.Hide();
        }
    }
}