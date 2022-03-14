using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskaSoba.Models
{
    internal class Hotel
    {
        private List<Soba> sobe;
        public Hotel()
        {
            this.sobe = new List<Soba>();
            this.sobe.Add(new Soba("10A",3,Soba.StatusSobe.Slobodna));
            this.sobe.Add(new Soba("10B",1,Soba.StatusSobe.Rezervirana));
            this.sobe.Add(new Soba("11A",2,Soba.StatusSobe.Slobodna));
            this.sobe.Add(new Soba("11B",4,Soba.StatusSobe.Slobodna));
            this.sobe.Add(new Soba("12A",5,Soba.StatusSobe.Slobodna));
            this.sobe.Add(new Soba("12B",3,Soba.StatusSobe.Rezervirana));
            this.sobe.Add(new Soba("13A",1,Soba.StatusSobe.Slobodna));
            this.sobe.Add(new Soba("13B",2,Soba.StatusSobe.Rezervirana));
        }

        public List<Soba> PronadjiSobe(int brojOsoba)
        {
            return this.sobe.FindAll(x=>x.Kapacitet>=brojOsoba && x.Status==Soba.StatusSobe.Slobodna);
        }

        public void RezervirajSobu(string oznaka)
        {
        if(this.sobe.Find(x => x.Oznaka == oznaka) != null)
            {
                this.sobe.Find(x => x.Oznaka == oznaka).Status = Soba.StatusSobe.Rezervirana;
                Console.WriteLine("Soba rezervirana");
            }
        else
            {
                Console.WriteLine("Ne postoji ta soba");
                return;
            }     
        }
    }
}
