using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Lib
{
    public abstract class Insan
    {
        internal protected int intkorumali { get; set; }
        protected internal int korumali { get; set; }
        public Insan()
        {
            KayitTarihi = DateTime.Now;
        }
        #region Fields
        string _tckn;
        string _ad;
        string _soyad;
        DateTime _dogumTarihi;
        DateTime _kayitTarihi;
        string _telefon;
        string _adres;
        Cinsiyetler _cinsiyet;
        #endregion
        #region Properties
        public string TCKN
        {
            set
            {
                if (!TCKNKontrol(value))
                    throw new Exception("TCKN Hatalı!");
                _tckn = value;
            }
            get { return _tckn; }
        }
        public string Ad
        {
            get { return _ad; }
            set
            {
                KarakterKontrol(value);
                _ad = AdBuyukKucukHarf(value);
            }
        }
        public string Soyad
        {
            get { return _soyad; }
            set
            {
                KarakterKontrol(value);
                _soyad = AdBuyukKucukHarf(value);
            }
        }
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }
        public DateTime KayitTarihi
        {
            private set { _kayitTarihi = value; }
            get { return _kayitTarihi; }
        }
        public string Telefon
        {
            set
            {
                if (value.Length != 11)
                    throw new Exception("Eksik ya da yanlış tuşladınız");
                _telefon = value;
            }
            get { return _telefon; }
        }
        public string Adres
        {
            set { _adres = value; }
            get { return _adres; }
        }
        public Cinsiyetler Cinsiyet
        {
            set { _cinsiyet = value; }
            get { return _cinsiyet; }
        }
        #endregion
        #region Methods
        private string AdBuyukKucukHarf(string isim) => isim.Substring(0, 1).ToUpper() + isim.Substring(1).ToLower();

        private void KarakterKontrol(string kelime)
        {
            foreach (char item in kelime)
            {
                if (char.IsDigit(item))
                    throw new Exception("İsminizde rakam bulunamaz!");
                else if (char.IsSymbol(item) || char.IsPunctuation(item))
                    throw new Exception("İsminizde özel karakter bulunamaz");
            }
        }
        bool TCKNKontrol(string tckn)
        {
            if (tckn.Length != 11)
                return false;
            foreach (char harf in tckn)
            {
                if (!char.IsDigit(harf))
                    return false;
            }
            if (tckn[0] == '0')
                return false;
            return true;
        }
        #endregion
        public override string ToString() => $"{Ad} {Soyad}";
        //public abstract bool CiftMi(int sayi);
        public virtual int YasGetir()
        {
            return DateTime.Now.Year - this.DogumTarihi.Year;
        }
        public virtual int Yas { get; set; }
        // Strongly Typed
        public static List<T> KisiAra<T>(string kelime, List<T> liste) where T : Insan
        {
            string ara = kelime.ToLower();
            return liste.Where(x => x.Ad.ToLower().Contains(ara) || x.Soyad.ToLower().Contains(ara)).ToList();
        }
        public static void KisiSil<T>(T kisi, List<T> liste) where T : Insan
        {
            var silinecek = liste.Where(x => x.TCKN == kisi.TCKN).FirstOrDefault();
            liste.Remove(silinecek);
        }
        public static bool TCKNKontrol<T>(T kisi, List<T> liste) where T : Insan
        {
            //var sonuc = liste.Where(x => x.TCKN == kisi.TCKN).Count();
            //if (sonuc == 0)
            //    return true;
            //else
            //    return false;
            var sonuc = liste.Where(x => x.TCKN == kisi.TCKN).FirstOrDefault();
            if (sonuc == null) return true;
            else return false;
        }
    }
    public enum Cinsiyetler
    {
        Erkek,
        Kadın,
        Belirsiz
    }
    public enum Branslar
    {
        Matematik,
        Fizik,
        Kimya,
        Biyoloji,
        Türkçe,
        İngilizce,
        Tarih,
        Coğrafya
    }
    public enum Departmanlar
    {
        Muhasebe,
        Temizlik,
        Yonetim,
        Guvenlik
    }
}
