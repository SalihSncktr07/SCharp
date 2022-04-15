using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatırlatıcı
{
    public partial class frmMesaj : Form
    {
        public frmMesaj()
        {
            InitializeComponent();
        }
        public string mesaj = " ";
        private void frmMesaj_Load(object sender, EventArgs e)
        {
            label1.Text = mesaj;
        }
    }
}
