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
using static Okul.WFA.FormMethods;
using static Okul.Lib.Insan;

namespace Okul.WFA
{
    public partial class OgrenciForm : BaseForm
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }
        public List<Ogrenci> Ogrenciler { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci ogr = new Ogrenci()
                {
                    Ad = txtAd.Text,
                    Adres = txtAdres.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    OgrenciNo = txtOgrenciNo.Text,
                    Sinif = txtSinif.Text,
                    Soyad = txtSoyad.Text, 
                    TCKN = txtTCKN.Text,
                    Telefon = txtTelefon.Text.Replace(" ", ""),
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString())
                };
                if (TCKNKontrol<Ogrenci>(ogr, Ogrenciler))
                    Ogrenciler.Add(ogr);
                else
                    throw new Exception("Bu TCKN daha önce sisteme kayıt edilmiş!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormTemizle(this.Controls);
                ListeyiDoldur<Ogrenci>(lst, Ogrenciler);
            }
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            FormMethods.ListeyiDoldur<Ogrenci>(lst, Ogrenciler);
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            FormMethods.ListeyiDoldur<Ogrenci>(lst, Insan.KisiAra<Ogrenci>(txtArama.Text, Ogrenciler));
        }
        Ogrenci secilenOgrenci;
        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItem == null)
            {
                btnSil.Enabled = false;
                secilenOgrenci = null;
                return;
            }
            btnSil.Enabled = true;
            secilenOgrenci = lst.SelectedItem as Ogrenci;
            txtAd.Text = secilenOgrenci.Ad;
            txtAdres.Text = secilenOgrenci.Adres;
            txtOgrenciNo.Text = secilenOgrenci.OgrenciNo;
            txtSinif.Text = secilenOgrenci.Sinif;
            txtSoyad.Text = secilenOgrenci.Soyad;
            txtTCKN.Text = secilenOgrenci.TCKN;
            txtTelefon.Text = secilenOgrenci.Telefon;
            dtpDogumTarihi.Value = secilenOgrenci.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)secilenOgrenci.Cinsiyet;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenOgrenci == null)
            {
                MessageBox.Show("Silinecek Öğrenci Bulunamadı");
                return;
            }
            DialogResult cevap = MessageBox.Show($"{secilenOgrenci.Ad} isimli öğrenciyi silmek istiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                secilenOgrenci = null;
                KisiSil<Ogrenci>(secilenOgrenci, Ogrenciler);
                FormTemizle(this.Controls);
                ListeyiDoldur<Ogrenci>(lst, Ogrenciler);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenOgrenci == null)
            {
                MessageBox.Show("Güncellenecek Öğrenci Bulunamadı");
                return;
            }

            secilenOgrenci = Ogrenciler.Where(x => x.TCKN == secilenOgrenci.TCKN).FirstOrDefault();

            try
            {
                secilenOgrenci.Ad = txtAd.Text;
                secilenOgrenci.Adres = txtAdres.Text;
                secilenOgrenci.DogumTarihi = dtpDogumTarihi.Value;
                secilenOgrenci.OgrenciNo = txtOgrenciNo.Text;
                secilenOgrenci.Sinif = txtSinif.Text;
                secilenOgrenci.Soyad = txtSoyad.Text;
                secilenOgrenci.TCKN = txtTCKN.Text;
                secilenOgrenci.Telefon = txtTelefon.Text.Replace(" ", "");
                secilenOgrenci.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                MessageBox.Show("Güncelleme işlemi başarılı");
                secilenOgrenci = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListeyiDoldur<Ogrenci>(lst, Ogrenciler);
            FormTemizle(this.Controls);
            
        }
    }
}
