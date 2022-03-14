using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvaranjeEmailRacuna.Models
{
    internal class LozinkaGenerator
    {
        public string GenerirajLozinku(string ime, string prezime)
        {
            string brojZnakova = (ime.Length + prezime.Length).ToString();
            return (prezime + brojZnakova).ToLower();
        }
    }
}
