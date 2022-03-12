using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobusnaKarta.Models
{
    public class AutobusniKolodvor
    {

        private List<string> linije;
      

        public AutobusniKolodvor()
        {
            linije = new List<string>
            {
                "Varaždin;Zagreb;80",
                "Varaždin;Čakovec;20",
                "Varaždin;Slavonski Brod;240",
                "Varaždin;Krapina;40",
                "Varaždin;Novi Marof;22",
                "Varaždin;Koprivnica;45",
                "Varaždin;Virovitica;100",
                "Varaždin;Osijek;220"
            };

        }
        private double IzracunajCijenu(int udaljenost,string tipKarte)
        {
            double cijenaKarte = 0;
            Console.WriteLine(tipKarte);
            switch (tipKarte.ToLower())
            {
                case "regularna":
                    {
                        cijenaKarte = 1.5 * udaljenost;
                        break;
                    }
                case "studentska":
                    {
                        cijenaKarte = 1.2 * udaljenost;
                        break;
                    }
                case "povratna":
                    {
                        cijenaKarte = 2 * udaljenost;
                        break;
                    }
                default:
                    Console.WriteLine("Zajeba si sa tipom karte");
                    break;
            }

            return cijenaKarte;
        }

        public string KupiKartu(string polazište, string odredište, string tipkarte)
        {
            Console.WriteLine("TU SAM");
            int udaljenost = 0;
            //trebamo izracunat udaljenost tu
            foreach  (string item in linije)
            {
                string[] polje = item.Split(';');
                if(polje[1].ToLower() == odredište.ToLower())
                {
                    udaljenost = int.Parse(polje[2]);
                    break;
                }
            }

            double iznos = IzracunajCijenu(udaljenost, tipkarte);

            string ispis = "Cijena za kartu tipa "+tipkarte+" , na relaciji "+ polazište + " - "+odredište + " iznosi: " +iznos;

            return ispis;
        }
    }
}
