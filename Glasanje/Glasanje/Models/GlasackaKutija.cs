﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje.Models
{
    internal class GlasackaKutija
    {
        private List<Glas> glasovi = new List<Glas>();

        public GlasackaKutija()
        {

        }

        private bool VecGlasao(string oib)
        {
            return glasovi.Find(x => x.OIB == oib) != null ? true : false;
        }

        public void Glasaj(string oib, string odabir)
        {
            if (VecGlasao(oib))
            {
                Console.WriteLine("vec je glasao");
                return;
            }
            this.glasovi.Add(new Glas(oib, odabir));
            return;
        }

        public void DohvatiRezultateGlasa()
        {
            int glasoviZa = 0;
            int glasoviProtiv = 0;
            int glasoviSuzdrzan = 0;
            foreach (Glas item in glasovi)
            {
                switch (item.Odabir)
                {
                    case "Z":
                        {
                            glasoviZa++;
                            break;
                        }
                    case "P":
                        {
                            glasoviProtiv++;
                            break;
                        }
                    case "S":
                        {
                            glasoviSuzdrzan++;
                            break;
                        }
                    default:
                        break;
                }
            }
            
            Console.WriteLine($"Rezultati glasanja: ZA:{glasoviZa} PROTIV:{glasoviProtiv} SUZDRZAN:{glasoviSuzdrzan}");
            return;
        }
    }
}
