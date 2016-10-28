using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Lib
{
    public class Personel : Insan, IMaas
    {
        public Departmanlar Departman { get; set; }

        public decimal Maas
        {
            get;

            set;
        }

        public string SicilNo
        {
            get;

            set;
        }

        public decimal MaasHesapla(int gun)
        {
            return Maas * gun / 30;
        }

        public override int YasGetir()
        {
            if (this.Cinsiyet == Cinsiyetler.Kadın)
                throw new Exception("Kadınların yaşı hesaplanmaz");
            return base.YasGetir();
        }
    }
}
