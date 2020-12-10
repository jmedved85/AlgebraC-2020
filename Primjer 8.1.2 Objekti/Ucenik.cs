using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer_8._1._2_Objekti
{
    class Ucenik
    {
        // Polja klase
        public DateTime DatumNastanka;
        public string Ime = "";
        public string Prezime = "";
        public int OcjenaIzMatematike = 0;
        public int OcjenaIzEngleskog = 0;
        public int OcjenaIzBiologije = 0;
        // Konstruktor1
        public Ucenik()
        {
            DatumNastanka = DateTime.Now;
        }
        // Konstruktor2
        public Ucenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        // Ostale metode
        public double Prosjek()
        {
            return (double)(OcjenaIzMatematike
                + OcjenaIzBiologije
                + OcjenaIzEngleskog)
                / 3;
        }
    }
}
