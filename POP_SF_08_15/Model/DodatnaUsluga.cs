using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF_08_15.Model
{
    public class DodatnaUsluga
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public double cena { get; set; }
        public bool obrisan { get; set; }
    }
}
