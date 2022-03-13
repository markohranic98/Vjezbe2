using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaEvidencija.Models
{
    internal class Drzava
    {
        public string Naziv { get; set; }
        public List<Grad> Gradovi = new List<Grad>();
        public static List<Drzava> Drzave = new List<Drzava>();
        public Drzava(string Naziv)
        {
            this.Naziv = Naziv;
            Drzave.Add(this);
        }

        public void DodajGradove()
        {
            int brojGradovaZaUnos = 0;
            Console.Write("Koliko gradova zelite: ");
            brojGradovaZaUnos = int.Parse(Console.ReadLine());
            for(int i = 0; i < brojGradovaZaUnos; i++)
            {
                Console.Write("Unesi grad " + (i+1) + ": ");
                string unos = Console.ReadLine();
                this.Gradovi.Add(new Grad(unos));
            }
        }

        public void IspisGradova()
        {
            Console.WriteLine("U drzavi " + this.Naziv + " nalaze se gradovi: ");
            foreach (Grad item in this.Gradovi)
            {
                Console.Write("Grad: " + item.NazivGrada+"\n");
            }
        }
    }
}
