using Okul.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ogrenciler = new List<Ogrenci>();
            Ogretmenler = new List<Ogretmen>();
        }
        public List<Ogrenci> Ogrenciler { get; set; }
        public List<Ogretmen> Ogretmenler { get; set; }
        OgrenciForm ogrForm;
        private void öğrenciFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ogrForm == null || ogrForm.IsDisposed)
            {
                ogrForm = new OgrenciForm();
                ogrForm.Ogrenciler = Ogrenciler;
                ogrForm.Show();
            }
        }
        OgretmenForm ormForm;
        private void öğretmenFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ormForm == null || ormForm.IsDisposed)
            {
                ormForm = new  OgretmenForm();
                ormForm.Ogretmenler = Ogretmenler;
                ormForm.Show();
            }
        }
    }
}