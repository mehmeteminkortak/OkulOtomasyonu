using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Lib
{
    public class KidemliPersonel : Personel
    {
        public int KidemDerecesi { get; set; }
        private int carpan = 0;
        public KidemliPersonel(int carpan)
        {
            this.carpan = carpan;
        }
        public override int YasGetir()
        {
            return base.YasGetir();
        }
        public override int Yas
        {
            get
            {
                return base.Yas + 1;
            }

            set
            {
                base.Yas = value;
            }
        }
    }
}
