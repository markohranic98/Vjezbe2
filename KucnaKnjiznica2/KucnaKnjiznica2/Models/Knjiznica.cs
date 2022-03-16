using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica2.Models
{
    internal class Knjiznica
    {
        public List<Knjiga> PopisKnjiga;

        public Knjiznica()
        {
            this.PopisKnjiga = new List<Knjiga>();
            this.PopisKnjiga.Add(new Knjiga("Prstenova druzina"));
            this.PopisKnjiga.Add(new Knjiga("Dvije kule"));
            this.PopisKnjiga.Add(new Knjiga("Povratak kralja"));
            this.PopisKnjiga.Add(new Knjiga("Ana Karenjina"));
            this.PopisKnjiga.Add(new Knjiga("Zlocin i kazna"));
            this.PopisKnjiga.Add(new Knjiga("Rat i mir"));
            this.PopisKnjiga.Add(new Knjiga("Jadnici"));
        }

        public void Posudi(string naslov, string osoba)
        {
           
            if (this.PopisKnjiga.Find(x => x.Naslov == naslov) != null )
            {
                if(this.PopisKnjiga.Find(x => x.Naslov == naslov).Dostupno == true)
                {
                    this.PopisKnjiga.Find(x => x.Naslov == naslov).Dostupno = false;
                    this.PopisKnjiga.Find(x => x.Naslov == naslov).Osoba = osoba;
                    return;
                }
                else
                {
                    Console.WriteLine("Ta knjiga je vec zauzeta");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ne postoji knjiga sa tim naslovom");
            }
        }
    }
}
