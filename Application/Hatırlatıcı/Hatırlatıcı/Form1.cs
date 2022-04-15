using System.Media;

namespace Hatırlatıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            button1.Enabled = true;
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                timer1.Stop();
                SoundPlayer player = new SoundPlayer();
                string sarkiyol = Application.StartupPath + "//Among-Us.wav";
                player.SoundLocation = sarkiyol;
                player.Play();
                a = 1;
            }
            button2.Enabled = true;
            if (a == 1)
            {
                frmMesaj frm = new frmMesaj();
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height);
                frm.mesaj = mesaj;
                frm.ShowDialog();
            }
        }
        public string mesaj = " ";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
            mesaj = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}