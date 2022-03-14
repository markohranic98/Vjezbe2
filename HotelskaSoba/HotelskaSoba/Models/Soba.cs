using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskaSoba.Models
{
    internal class Soba
    {
        public string Oznaka { get; set; }
        public int Kapacitet { get; set; }
        public enum StatusSobe
        {
            Rezervirana,
            Slobodna
        }

        public StatusSobe Status = new StatusSobe();

        public Soba(string oznaka, int kapacitet, StatusSobe status)
        {
            this.Oznaka = oznaka;
            this.Kapacitet = kapacitet;
            this.Status = status;
        }
    }
}
