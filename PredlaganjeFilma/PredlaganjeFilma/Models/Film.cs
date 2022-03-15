using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredlaganjeFilma.Models
{
    internal class Film
    {
        public string Naziv { get; set; }
        public enum Zanrovi
        {
            Komedija,Akcija,Horor
        }
        public Zanrovi Zanr = new Zanrovi();
        public int Trajanje { get; set; }
        public bool VecGledan { get; set; }
        public Film(string naziv, Zanrovi zanr, int trajanje, bool vecGledan)
        {
            this.Naziv = naziv;
            this.Zanr = zanr;
            this.Trajanje = trajanje;
            this.VecGledan = vecGledan;
        }

        public Film()
        {

        }

        public string DohvatiInfo()
        {
            return $"{this.Naziv} ({this.Zanr} {this.Trajanje})";
        }
       
    }
}
