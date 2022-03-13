using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucnaKnjiznica1.Models
{
    internal class Knjiga
    {
        public string ISBN { get; set; }
        public string Naslov { get; set; }

        public enum StatusKnjige
        {
            Dostupno,
            NaPosudbi
        }

        public StatusKnjige Status = new StatusKnjige();

        public Knjiga(string isbn, string naslov, StatusKnjige status)
        {
            this.ISBN = isbn;
            this.Naslov = naslov;
            this.Status = status;
        }
    }
}
