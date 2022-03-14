using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutobusnaKarta.Models
{
    public class AutobusniKolodvor
    {
        private List<Linija> linije;

        public AutobusniKolodvor()
        {
            linije = new List<Linija>();
            this.linije.Add(new Linija("Varazdin","Zagreb",80));
            this.linije.Add(new Linija("Varazdin","Cakovec",20));
            this.linije.Add(new Linija("Varazdin","Slavonski Brod",240));
            this.linije.Add(new Linija("Varazdin","Krapina",40));
            this.linije.Add(new Linija("Varazdin","Novi Marof",22));
            this.linije.Add(new Linija("Varazdin","Koprivnica",45));
            this.linije.Add(new Linija("Varazdin","Virovitica",100));
            this.linije.Add(new Linija("Varazdin","Osijek",220));
        }

        private double IzracunajCijenu(int udaljenost,string tipKarte)
        {
            switch (tipKarte)
            {
                case "Povratna":
                    {
                        return udaljenost * 2;
                    }
                case "Studentska":
                    {
                        return udaljenost * 1.2;
                    }
                case "Regularna":
                    {
                        return udaljenost * 1.5;
                    }
                default:
                    return 0;
            }
        }

        public string KupiKartu(string polaziste,string odrediste, string tipKarte)
        {
            int udaljenost = linije.Find(x => (x.Polaziste == polaziste && x.Odrediste == odrediste)).Udaljenost;
            return "Cijena za kartu tipa " + tipKarte + ", na relaciji " + polaziste + "-" + odrediste + " iznosi " + IzracunajCijenu(udaljenost, tipKarte);
        }
    }
}
