using System;
using System.Collections.Generic;
using System.Text;

namespace SimulaEpi
{
    class Cell
    {
        private int cellStatus;
        private int latentReady;


        public Cell(){
            this.cellStatus = 1;
            this.latentReady = 0;

        }

        public Cell(int stat, int latent) {

            this.cellStatus = stat;
            this.latentReady = latent;

        }

        public void setCellStatus(int val) {

            this.cellStatus = val;

        }

        public int getCellStatus() {

            return this.cellStatus;

        }

        public void setLatentReady(int val) {

            this.latentReady = val;
        
        }

        public int getLatentReady() { 
        
            return this.latentReady;
        
        }

        public void latentDecrement() {

            this.latentReady -= 1;
        }

    }
}
