using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica3.Models
{
    internal class Knjiznica
    {
        public List<Knjiga> Knjige { get; set; }
        public List<Posudba> Posudbe = new List<Posudba>();

        public Knjiznica()
        {
            this.Knjige = new List<Knjiga>();
            this.Knjige.Add(new Knjiga("1111","Crvenkapica"));
            this.Knjige.Add(new Knjiga("2222","Pepeljuga"));
            this.Knjige.Add(new Knjiga("3333","Trnoruzica"));
        }

        public void PosudiKnjigu(string osoba, string isbn)
        {
            if (this.Knjige.Find(x => x.ISBN == isbn) != null)
            {
                this.Posudbe.Add(new Posudba(osoba,this.Knjige.Find(x => x.ISBN == isbn)));
                Posudba zadnjaPosudba = this.Posudbe.FindLast(x=>x.GetType()!=null);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("---------------POSUDBA--------------");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Osoba: "+zadnjaPosudba.Osoba);
                Console.WriteLine("ISBN knjige: "+zadnjaPosudba.PosudjenaKnjiga.ISBN);
                Console.WriteLine("Naslov Knjige: "+zadnjaPosudba.PosudjenaKnjiga.Naslov);
                Console.WriteLine("Datum posudbe: "+zadnjaPosudba.Datum);
            }
            else
            {
                Console.WriteLine("Ne postoji knjiga sa tim isbn-om");
            }
        }
    }
}
