namespace RandomColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        Random rnd2 = new Random();
        int Random, Random2, RenkSirasi;
        int SoruSirasi = 1;
        string[] RenkListesi = new string[] { "Red", "Yellow", "Pink", "Green", "Black" };

        private void Form1_Load(object sender, EventArgs e)
        {
            RenkCek();
        }
        string[] RenkListesiTR = new string[] { "Kýrmýzý", "Sarý", "Pembe", "Yeþil", "Siyah" };

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor.Name == RenkListesi[RenkSirasi])
            {
                MessageBox.Show("Tebrikler, Doðru Cevap");
                if (SoruSirasi <= 40)
                {
                    SoruSirasi++;
                    RenkCek();
                }
                else
                {
                    MessageBox.Show("Tüm Sorularý Cevaplanýnýz Tebrik Ederim");
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm Yanlýþ Cevap, Lütfen Tekrar Deneyiniz");
            }
        }
        void RenkCek()
        {
            Random2 = rnd .Next(0,4);
            for (int i = 0; i < 4; i++)
            {
                Random = rnd.Next(0, 40);

                switch (i)
                {
                    case 0:
                        button2.BackColor = Color.FormName(RenkListesi[Random].ToString());
                        if (Random2 == 0)
                        {
                            label1.Text = "Aþaðýdakilerden Renklerden Hangisi" + RenkListesiTR[Random] + "?";
                            RenkSirasi = Random;
                        }
                        break;
                    case 1:
                        button2.BackColor = Color.FormName(RenkListesi[Random].ToString());
                        if (Random2 == 1)
                        {
                            label1.Text = "Aþaðýdakilerden Renklerden Hangisi" + RenkListesiTR[Random] + "?";
                            RenkSirasi = Random;
                        }
                        break;

                    case 2:
                        button3.BackColor = Color.FormName(RenkListesi[Random].ToString());
                        if (Random2 == 2)
                        {
                            label1.Text = "Aþaðýdakilerden Renklerden Hangisi" + RenkListesiTR[Random] + "?";
                            RenkSirasi = Random;
                        }
                        break;

                    case 3:
                        button4.BackColor = Color.FormName(RenkListesi[Random].ToString());
                        if (Random2 == 3)
                        {
                            label1.Text = "Aþaðýdakilerden Renklerden Hangisi" + RenkListesiTR[Random] + "?";
                            RenkSirasi = Random;
                        }
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor.Name == RenkListesi[RenkSirasi])
            {
                MessageBox.Show("Tebrikler, Doðru Cevap");
                if (SoruSirasi <= 40)
                {
                    SoruSirasi++;
                    RenkCek();
                }
                else
                {
                    MessageBox.Show("Tüm Sorularý Cevaplanýnýz Tebrik Ederim");
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm Yanlýþ Cevap, Lütfen Tekrar Deneyiniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor.Name == RenkListesi[RenkSirasi])
            {
                MessageBox.Show("Tebrikler, Doðru Cevap");
                if (SoruSirasi <= 40)
                {
                    SoruSirasi++;
                    RenkCek();
                }
                else
                {
                    MessageBox.Show("Tüm Sorularý Cevaplanýnýz Tebrik Ederim");
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm Yanlýþ Cevap, Lütfen Tekrar Deneyiniz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor.Name == RenkListesi[RenkSirasi])
            {
                MessageBox.Show("Tebrikler, Doðru Cevap");
                if (SoruSirasi <= 40)
                {
                    SoruSirasi++;
                    RenkCek();
                }
                else
                {
                    MessageBox.Show("Tüm Sorularý Cevaplanýnýz Tebrik Ederim");
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm Yanlýþ Cevap, Lütfen Tekrar Deneyiniz");
            }
        }
    }
}