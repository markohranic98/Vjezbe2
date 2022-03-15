using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo.Models
{
    internal class PrvenstvoClass
    {
        public List<Reprezentacija> Reprezentacije = new List<Reprezentacija>();
        public List<Utakmica> Utakmice = new List<Utakmica>();

        public PrvenstvoClass()
        {

        }

        public void UnesiReprezentaciju()
        {
            Console.WriteLine("Unesi oznaku reprezentacije: ");
            string oznaka = Console.ReadLine();
            Console.WriteLine("Unesi naziv reprezentacije: ");
            string naziv = Console.ReadLine();
            this.Reprezentacije.Add(new Reprezentacija(oznaka, naziv));
            Console.WriteLine("Reprezentacija dodana");
            return;
        }

        public void DodajUtakmicu()
        {
            Console.WriteLine("Unesi oznaku domacina");
            string oznakaDomacina = Console.ReadLine();
            Console.WriteLine("Unesi oznaku gosta");
            string oznakaGosta = Console.ReadLine();
            Console.WriteLine("Unesi broj golova domacina:");
            int brojGolovaDomacina = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj golova gosta:");
            int brojGolovaGosta = int.Parse(Console.ReadLine());

            if(Reprezentacije.Find(x=>x.Oznaka==oznakaDomacina) == null || Reprezentacije.Find(x=>x.Oznaka==oznakaGosta) == null)
            {
                Console.WriteLine("Kriva oznaka neke reprezentacije");
                return;
            }
            this.Utakmice.Add(new Utakmica(Reprezentacije.Find(x => x.Oznaka == oznakaDomacina), Reprezentacije.Find(x => x.Oznaka == oznakaGosta), brojGolovaDomacina, brojGolovaGosta));

        }

        public void GenerirajTablicuRezultata()
        {
            foreach (var item in Utakmice)
            {
                Console.WriteLine(item.GenerirajIspis());
            }
        }

        public void GenerirajBodovnuLjestvicu()
        {
            Console.WriteLine("REP   OU  POB   NER   IZG   POZ   PRZ   RUZ   BOD");
            foreach(var item in Reprezentacije)
            {
                Console.WriteLine($"{item.Oznaka}    {Odredi_OU(item)}    {Odredi_POB(item)}     {Odredi_NER(item)}     {Odredi_IZG(item)}     {Odredi_POT(item)}     {Odredi_PRZ(item)}     {Odredi_RUZ(item)}     {Odredi_BOD(item)}");
            }
            return;
        }
        
        public string Odredi_OU(Reprezentacija reprezentacija)
        {
            return Utakmice.FindAll(x=>x.GenerirajIspis().Contains(reprezentacija.Oznaka)).Count.ToString();
        }

        public string Odredi_POB(Reprezentacija reprezentacija)
        {
            return Utakmice.FindAll(x=>(x.Domacin.Oznaka == reprezentacija.Oznaka && x.BrojZgoditakaDomacin > x.BrojZgoditakaGost) || (x.Gost.Oznaka==reprezentacija.Oznaka && x.BrojZgoditakaGost>x.BrojZgoditakaDomacin)).Count.ToString();
        }

        public string Odredi_NER(Reprezentacija reprezentacija)
        {
            return Utakmice.FindAll(x => x.GenerirajIspis().Contains(reprezentacija.Oznaka) && x.BrojZgoditakaDomacin == x.BrojZgoditakaGost).Count.ToString();
        }
        
        public string Odredi_IZG(Reprezentacija reprezentacija)
        {
            return Utakmice.FindAll(x => (x.Domacin.Oznaka == reprezentacija.Oznaka && x.BrojZgoditakaDomacin < x.BrojZgoditakaGost) || (x.Gost.Oznaka == reprezentacija.Oznaka && x.BrojZgoditakaGost < x.BrojZgoditakaDomacin)).Count.ToString();
        }

        public string Odredi_POT( Reprezentacija reprezentacija)
        {
            int brojGolova = 0;
            foreach (var item in Utakmice)
            {
                if (item.Domacin.Oznaka == reprezentacija.Oznaka)
                {
                    brojGolova += item.BrojZgoditakaDomacin;
                }
                else if(item.Gost.Oznaka == reprezentacija.Oznaka)
                {
                    brojGolova += item.BrojZgoditakaGost;
                }
            }
            return brojGolova.ToString();
        }
        public string Odredi_PRZ(Reprezentacija reprezentacija)
        {
            int brojGolova = 0;
            foreach (var item in Utakmice)
            {
                if (item.Domacin.Oznaka == reprezentacija.Oznaka)
                {
                    brojGolova += item.BrojZgoditakaGost;
                }
                else if (item.Gost.Oznaka == reprezentacija.Oznaka)
                {
                    brojGolova += item.BrojZgoditakaDomacin;
                }
            }
            
            return brojGolova.ToString();
        }

        public string Odredi_RUZ(Reprezentacija reprezentacija)
        {
            return (int.Parse(Odredi_POT(reprezentacija)) - int.Parse(Odredi_PRZ(reprezentacija))).ToString();
        }

        public string Odredi_BOD(Reprezentacija reprezentacija)
        {
            return (int.Parse(Odredi_POB(reprezentacija))*3 + int.Parse(Odredi_NER(reprezentacija))).ToString();
        }
    }
}
