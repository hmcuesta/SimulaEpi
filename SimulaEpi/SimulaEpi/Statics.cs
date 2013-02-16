using System;
using System.Collections.Generic;
using System.Text;

namespace SimulaEpi
{
    class Statics
    {
        public Statics() {

            this.susceptible = 0;
            this.latent = 0;
            this.infectious = 0;
            this.recovery = 0;
            this.vaccinated = 0;
            this.removed = 0;
        
        }

        public int susceptible { get; set; }
        public int latent {get;set;}
        public int infectious { get; set; }
        public int recovery { get; set; }
        public int vaccinated { get; set; }
        public int removed { get; set; }
        
    }
}
