using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Lib
{
    public class Ogretmen : Insan, IMaas
    {
        public Branslar Brans { get; set; }
        private const decimal MaasSabiti = 1.15m;
        decimal _maas;
        public decimal Maas
        {
            get
            {
                return _maas;
            }

            set
            {
                _maas = value * MaasSabiti;
            }
        }

        public string SicilNo
        {
            get;

            set;
        }

        public decimal MaasHesapla(int gun)
        {
            return Maas * gun / 24;
        }
        public override string ToString() => $"{base.ToString()} - {Maas:c2}";

    }
}
