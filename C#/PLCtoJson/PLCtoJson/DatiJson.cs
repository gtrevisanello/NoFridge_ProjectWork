using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLCtoJson
{
    class DatiJson
    {
        public string codice;
        public string articolo;
        public int parzialeDiProduzione;
        public int PezziBuoni;
        public int PezziScarto;
        public bool[] statoMacchina=new bool[8];
        public int velocitàMacchina;
        public int out1;
        public int out2;
        public string avvisoPerUffici;
    }
}
