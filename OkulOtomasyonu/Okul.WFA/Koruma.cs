using Okul.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.WFA
{
    public class Koruma : Insan
    {
        public Koruma()
        {
            this.intkorumali = 0;
            this.korumali = 0;
        }
    }
    public class UstKoruma
    {
        public UstKoruma()
        {
            Insan ins = new Ogrenci();
        }
    }
}
