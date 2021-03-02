using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BazaPoklona.Models
{
    public partial class Poklon
    {
              
        public int ID { get; set; }

        public string Naziv { get; set; }
        public int VrstaRobe { get; set; }
        public bool Kupljen { get; set; }
        public double Cijena { get; set; }

        public virtual VrstaRobe VrstaRobeNavigation { get; set; }
    }
}
