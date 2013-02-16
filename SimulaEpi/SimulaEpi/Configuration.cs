using System;
using System.Collections.Generic;
using System.Text;

namespace SimulaEpi
{
    [Serializable]
    class Configuration
    {

        public double transmissionProb { get; set; }//
        public int avgContacts { get; set; }//
        public int latentP { get; set; }//
        public int infectiousP { get; set; }//
        public int recoveriP { get; set; }//
        public int model { get; set; }//
        public int pointerSel { get; set; }//
        public int seed { get; set; }//




    }
}
