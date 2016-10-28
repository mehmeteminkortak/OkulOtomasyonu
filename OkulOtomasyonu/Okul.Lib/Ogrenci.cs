using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Lib
{
    public class Ogrenci : Insan
    {
        public Ogrenci()
        {
            this.intkorumali = 0;
            this.korumali = 0;
        }
        public string OgrenciNo { get; set; }
        public string Sinif { get; set; }
    }
}
