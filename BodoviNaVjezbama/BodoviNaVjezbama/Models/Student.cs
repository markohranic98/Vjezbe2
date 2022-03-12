using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviNaVjezbama.Models
{
    public class Student
    {
        public string JMBAG { get; set; }
        public string StudentName { get; set; }
        //moze se dodat i prezime i bla bla ali whatever nije mi se dalo zbog upisa
        public List<Vjezbe> PohadaneVjezbe = new List<Vjezbe>();
        public static List<Student> Studenti = new List<Student>();
        public int bodovi { get; set; }
        
        public Student(string JMBAG, string Name)
        {
            this.JMBAG = JMBAG;
            this.StudentName = Name;
            this.bodovi = 0;

            Studenti.Add(this);
        }

        public void IspisStudenata()
        {
            Console.WriteLine("JMBAG studenta: " + this.JMBAG + "\nIme studenta: " + this.StudentName);
        }

        public void DodajBodove(Vjezbe vjezbe)
        {
            this.bodovi += vjezbe.BodoviNaVjezbama;
            this.PohadaneVjezbe.Add(vjezbe);
        }
    }
}
