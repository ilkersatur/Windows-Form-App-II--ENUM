using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum DepoHareketleri {Giris, Cikis, Iade, Fire };
    internal class Depo
    {
        public DepoHareketleri Hareket { get; set; }
    }
}
