using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POP_SF_08_15.Utils;

namespace POP_SF_08_15.Model
{
    public class Projekat
    {
        public static Projekat Instance { get; private set; } = new Projekat();
        private List<TipNamestaja> tipNamestajaLista;
        public List<TipNamestaja> TipNamestajaLista
        {
            get
            {
                tipNamestajaLista = GenericSerializer.Deserialize<TipNamestaja>("tipNamestaja.xml");
                return tipNamestajaLista;
            }
            set
            {
                tipNamestajaLista = value;
                GenericSerializer.Serialize<TipNamestaja>("tipNamestaja.xml");
            }
        }

    }
}
