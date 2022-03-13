using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaEvidencija.Models
{
    internal class KoronaZapis
    {
        public int BrojZarazenih { get; set; }
        public DateTime Datum;

        public KoronaZapis()
        {
            this.Datum = DateTime.Now;
        }
    }
}
