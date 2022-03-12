using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviNaVjezbama.Models
{
    public class Vjezbe
    {
        public string NazivVjezbe  { get; set; }

        public int BodoviNaVjezbama { get; set; }
        


        public Vjezbe(string NazivVjezbe)
        {
           this.NazivVjezbe = NazivVjezbe;
           this.OcjeniVjezbe();
        }

        public void OcjeniVjezbe()
        {
            foreach (Student item in Student.Studenti)
            {
                Console.WriteLine("Unesi broj bodova za studenta: " + item.StudentName);
                int brojBodovaNaVjezbama = int.Parse(Console.ReadLine());
                this.BodoviNaVjezbama = brojBodovaNaVjezbama;
                item.DodajBodove(this);
            }
        }

    }
}
