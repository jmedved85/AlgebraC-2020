using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer_8._1._3_Osoba
{
    // Klasa "Osoba" sa svojstvima "Ime, Prezime, Starost".
    class Osoba
    {
        string ime;
        public string Ime 
        {
            get { return ime; }
            set { ime = value; } 
        }

        string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        int starost;
        public int Starost
        {
            get { return starost; }
            set
            {
                if (value > 0)
                {
                    starost = value;
                }
                else
                {
                    Exception ex = new Exception("Neispravan unos!");
                    throw ex;
                }
            }
        }
        
    }
}
