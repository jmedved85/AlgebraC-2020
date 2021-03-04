using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BazaPoklona.Models
{
    [Keyless]
    public class OstvareniPrometPoklonModel : Poklon
    {        
        public new string Naziv { get; set; }
        public new int VrstaRobe { get; set; }
        public new double Cijena { get; set; }
    }
}
