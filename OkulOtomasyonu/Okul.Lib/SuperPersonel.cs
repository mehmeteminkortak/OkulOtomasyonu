using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Lib
{
    public sealed class SuperPersonel : KidemliPersonel
    {
        public bool SuperMisin { get; set; }
        public SuperPersonel(int carpan) : base(carpan)
        {

        }
    }
}
