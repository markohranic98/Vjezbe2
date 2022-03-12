using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodoviNaVjezbama.Models;

namespace BodoviNaVjezbama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //studentu moraju bit pridruzene vjezbe sa brojem bodova
            string unos = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1. Dodavanje studenata");
                Console.WriteLine("2. Dodavanje vježbe i ocjenjivanje studenata");
                Console.WriteLine("3. Ispis bodova");
                Console.WriteLine("4. Izlaz");
                Console.Write("Što želite: ");

                unos = Console.ReadLine();

                switch (unos)
                {
                    case "1":
                        {
                            Console.Write("Unesi ime studenta: ");
                            string studentName = Console.ReadLine();
                            Console.Write("Unesi JMBAG studenta: ");
                            string jmbagStudenta = Console.ReadLine();
                            Student noviStudent = new Student(jmbagStudenta, studentName);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Napisi naziv/redni broj vjezbi ili sta god hoces: ");
                            Vjezbe vjezbe = new Vjezbe(Console.ReadLine());
                            break;
                        }
                    case "3":
                        {
                            foreach (Student item in Student.Studenti)
                            {
                                Console.WriteLine("Student " + item.StudentName + " ima " + item.bodovi + " bodova");
                            }
                            Console.ReadLine();
                            break;
                        }
                    case "4":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sjebo si kod unosa");
                            break;
                        }
                }
            } while (unos != "4");
        }
    }
}
