using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica1.Models
{
    internal class Knjiznica
    {
        private List<Knjiga> popisKnjiga;

        public Knjiznica()
        {
            this.popisKnjiga = new List<Knjiga>();
            this.popisKnjiga.Add(new Knjiga("1111","Crvenkapica",Knjiga.StatusKnjige.Dostupno));
            this.popisKnjiga.Add(new Knjiga("2222","Pepeljuga",Knjiga.StatusKnjige.Dostupno));
            this.popisKnjiga.Add(new Knjiga("3333","Trnoruzica",Knjiga.StatusKnjige.Dostupno));
            this.popisKnjiga.Add(new Knjiga("4444","Frozen",Knjiga.StatusKnjige.Dostupno));
        }

        public Knjiga DohvatiKnjigu(string isbn)
        {
            return this.popisKnjiga.Find(x=>x.ISBN==isbn);
        }

        public void Posudi(string isbn)
        {
            if(DohvatiKnjigu(isbn).ISBN != null)
            {
                this.popisKnjiga.Find(x => x.ISBN == isbn).Status = Knjiga.StatusKnjige.NaPosudbi;
                Console.WriteLine(popisKnjiga.Find(x => x.ISBN == isbn).Status);
                Console.WriteLine(popisKnjiga.Find(x => x.ISBN == isbn).Naslov);
                Console.WriteLine(popisKnjiga.Find(x => x.ISBN == isbn).ISBN);
            }
        }
    }
}
