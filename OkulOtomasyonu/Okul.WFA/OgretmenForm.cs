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
    public partial class OgretmenForm : BaseForm
    {
        public OgretmenForm()
        {
            InitializeComponent();
        }
        public List<Ogretmen> Ogretmenler { get; set; }
        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(Branslar)));
            FormMethods.ListeyiDoldur<Ogretmen>(lst, Ogretmenler);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Ogretmen orm = new Ogretmen()
                {
                    Ad = txtAd.Text,
                    Adres = txtAdres.Text,
                    Brans = (Branslar)Enum.Parse(typeof(Branslar), cmbBrans.SelectedItem.ToString()),
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Maas = nMaas.Value,
                    SicilNo = txtSicil.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKN.Text,
                    Telefon = txtTelefon.Text.Replace(" ", "")
                };
                if (Insan.TCKNKontrol<Ogretmen>(orm, Ogretmenler))
                    Ogretmenler.Add(orm);
                else
                    throw new Exception("TCKN Kontrol et");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormMethods.FormTemizle(this.Controls);
                FormMethods.ListeyiDoldur<Ogretmen>(lst, Ogretmenler);
            }
        }
        Ogretmen seciliOgretmen;
        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItem == null)
            {
                btnSil.Enabled = false;
                seciliOgretmen = null;
                return;
            }
            seciliOgretmen = lst.SelectedItem as Ogretmen;
            txtAd.Text = seciliOgretmen.Ad;
            txtAdres.Text = seciliOgretmen.Adres;
            txtSoyad.Text = seciliOgretmen.Soyad;
            txtTCKN.Text = seciliOgretmen.TCKN;
            txtTelefon.Text = seciliOgretmen.Telefon;
            dtpDogumTarihi.Value = seciliOgretmen.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliOgretmen.Cinsiyet;
            txtSicil.Text = seciliOgretmen.SicilNo;
            nMaas.Value = seciliOgretmen.Maas;
            cmbBrans.SelectedIndex = (int)seciliOgretmen.Brans;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliOgretmen == null)
            {
                MessageBox.Show("Silinecek Öğretmen bulunamadı");
                return;
            }
            DialogResult sonuc = MessageBox.Show($"{seciliOgretmen.Ad} isimli öğretmen silinsin mi?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
                Insan.KisiSil<Ogretmen>(seciliOgretmen, Ogretmenler);
            FormMethods.ListeyiDoldur<Ogretmen>(lst, Ogretmenler);
            FormMethods.FormTemizle(this.Controls);
            seciliOgretmen = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliOgretmen == null)
            {
                MessageBox.Show("Güncellenecek Öğretmen bulunamadı");
                return;
            }
            seciliOgretmen = Ogretmenler.Where(x => x.TCKN == seciliOgretmen.TCKN).First();
            try
            {
                seciliOgretmen.Ad = txtAd.Text;
                seciliOgretmen.Adres = txtAdres.Text;
                seciliOgretmen.DogumTarihi = dtpDogumTarihi.Value;
                seciliOgretmen.Soyad = txtSoyad.Text;
                seciliOgretmen.TCKN = txtTCKN.Text;
                seciliOgretmen.Telefon = txtTelefon.Text.Replace(" ", "");
                seciliOgretmen.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                seciliOgretmen.Brans = (Branslar)Enum.Parse(typeof(Branslar), cmbBrans.SelectedItem.ToString());
                seciliOgretmen.SicilNo = txtSicil.Text;
                seciliOgretmen.Maas = nMaas.Value;
                MessageBox.Show("Güncelleme işlemi başarılı");
                seciliOgretmen = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormMethods.ListeyiDoldur<Ogretmen>(lst, Ogretmenler);
            FormMethods.FormTemizle(this.Controls);
        }
    }
}
