using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Lib
{
    public interface IMaas
    {
        decimal Maas { get; set; }
        string SicilNo { get; set; }
        decimal MaasHesapla(int gun);
    }
}
