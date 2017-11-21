using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_SF_08_15.Model
{
    public class Akcija
    {
        public int id { get; set; }
        public DateTime datumPocetka { get; set; }
        public DateTime datumZavrsetka { get; set; }
        public decimal popust { get; set; }
        public bool obrisan { get; set; }


    }
}
