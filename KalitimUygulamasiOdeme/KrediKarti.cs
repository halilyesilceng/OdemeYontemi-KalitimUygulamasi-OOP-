using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimUygulamasiOdeme
{
    public class KrediKarti : Odeme
    {
        public int KartNo { get; set; }
        public DateTime SonaErmeTarihi { get; set; }
        public string CVC2 { get; set; }

        public KrediKarti()
        {
            //ToDo
        }
    }
}
