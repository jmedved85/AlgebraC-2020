using System.Collections.Generic;

namespace Zadaca_16_12_2020
{
    internal class Kolac
    {
        private string ime;
        private string sastojak;
        private float kolicina;

        public static List<string> DodajSastojak = new List<string>();
        public static List<float> DodajKolicinu = new List<float>();

        internal string Ime { get => ime; set => ime = value; }
        internal string Sastojak
        {
            get { return sastojak; }
            set
            {
                DodajSastojak.Add(sastojak);
                sastojak = value;
            }
        }
        internal float Kolicina
        {
            get { return kolicina; }
            set
            {
                DodajKolicinu.Add(kolicina);
                kolicina = value;
            }
        }        
    }
}