using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo.Models
{
    internal class Utakmica
    {
        public Reprezentacija Domacin { get; set; }
        public Reprezentacija Gost { get; set; }
        public int BrojZgoditakaDomacin { get; set; }
        public int BrojZgoditakaGost { get; set; }

        public Utakmica(Reprezentacija domacin, Reprezentacija gost, int brojZgoditakaDomacin,int brojZgoditakaGost)
        {
            Domacin = new Reprezentacija();
            Gost = new Reprezentacija();
            this.Domacin = domacin;
            this.Gost = gost;
            this.BrojZgoditakaGost = brojZgoditakaGost;
            this.BrojZgoditakaDomacin = brojZgoditakaDomacin;
        }

        public string GenerirajIspis()
        {
            return Domacin.Oznaka + " " + BrojZgoditakaDomacin + ":" + BrojZgoditakaGost + " " + Gost.Oznaka;
        }

        public Utakmica()
        {

        }
    }
}
