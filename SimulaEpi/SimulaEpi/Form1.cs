using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.IO;


namespace SimulaEpi
{
    public partial class Form1 : Form
    {
        private Cell[,] universo = new Cell[140, 140];

        private System.Drawing.Graphics g;
        private Bitmap saveGraph = new Bitmap(562,562);
        
        private Configuration conf = new Configuration();
        private Statics statics = new Statics();
        private List<Statics> lStatics = new List<Statics>();
        private Random r;
        private RandomNumberGenerator rand = RandomNumberGenerator.Create();
        
        private Boolean shouldPaint = false;
        private Boolean playCtl;

        // Vaccination Strategies

        private Boolean stActive = false;
        private int noVacPerTime;
        private int typeStrategie = 1;
        private int valStrategie;


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            g = Graphics.FromImage(saveGraph);

            //datos de default
            conf.infectiousP = 5;
            conf.latentP = 5;
            conf.recoveriP = 5;
            conf.model = 2;
            conf.seed = 300;
            conf.avgContacts = 10;
            conf.pointerSel = 3;
            conf.transmissionProb = 0.10;

            //control de status de botones
            playCtl = false;
            go.Enabled = false;
            pause.Enabled = false;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
            radioTime.Checked = true;
        }


        //metodo principal de reglas *******RULES******
         private void fillbyTime()
        {
             int i, j;
            // r = new Random(conf.seed);
             
            for (i = 0; i < 140; i++)    
            {
                
                for (j = 0; j < 140; j++)
                {
                    // get current cell
                    Cell cTemp = universo[i, j];

                    
                    // descartamos la cellula, recuperada, vacunada o eliminada 
                    if (cTemp.getCellStatus() <= 3)
                    {
                        //int cRc = (int)Math.Ceiling(conf.avgContacts / 2.0);
                        int cRc = conf.avgContacts / 2;
                        int contact;
                        for (contact = 1; contact <= cRc; contact++)
                        {

                            // get random cell
                            int x2 = r.Next(0, 140);
                            int y2 = r.Next(0, 140);

                            Cell cContact = universo[x2, y2];

                                // rules 
                                if (cTemp.getCellStatus() == cContact.getCellStatus())
                                {
                                    continue;
                                }
                                else if (cTemp.getCellStatus() == 3 && cContact.getCellStatus() == 1)
                                {
                                    // si A esta infectado entonces infecto a B
                                    //double eval = r.Next(0, 100) / 100.0;
                                    double eval = r.NextDouble();
                                    if ( eval <= conf.transmissionProb)
                                    {
                                        cContact.setCellStatus(2);
                                        cContact.setLatentReady(conf.latentP);
                                        
                                    }

                                }
                                else if (cTemp.getCellStatus() == 1 && cContact.getCellStatus() == 3)
                                {
                                    // si B esta infectado entonces infecto a A
                                    //double eval = r.Next(0, 100) / 100.0;
                                    double eval = r.NextDouble();
                                    if (eval <= conf.transmissionProb)
                                    {
                                        cTemp.setCellStatus(2);
                                        cTemp.setLatentReady(conf.latentP);
                                    }
                                }
                            
                            // updating cell B
                            universo[x2, y2] = cContact;
                            
                        }
                        
                    }//cierra descarte

                    
                    // become infectious latentcy process
                    if (cTemp.getCellStatus() == 2 && cTemp.getLatentReady() == 0)
                    {
                        cTemp.setCellStatus(3);
                        cTemp.setLatentReady(conf.infectiousP);

                    }
                    else if (cTemp.getCellStatus() == 2 && cTemp.getLatentReady() > 0) {

                        cTemp.latentDecrement();
                    
                    }
                   
                    if (cTemp.getCellStatus() == 3 && cTemp.getLatentReady() == 0)
                    {
                        //become recover
                        cTemp.setCellStatus(4);
                        cTemp.setLatentReady(conf.recoveriP);

                    }
                    else if (cTemp.getCellStatus() == 3 && cTemp.getLatentReady() > 0)
                    {

                        cTemp.latentDecrement();

                    }

                    //SIR control  SIR == 1  and SIS == 2
                    if (conf.model == 1)
                    {

                        if (cTemp.getCellStatus() == 4 && cTemp.getLatentReady() == 0)
                        {
                            //become susepible
                            cTemp.setCellStatus(1);
                            cTemp.setLatentReady(0);

                        }
                        else if (cTemp.getCellStatus() == 4 && cTemp.getLatentReady() > 0)
                        {

                            cTemp.latentDecrement();

                        }
                        
                    }
                    
                    //updating cell A
                    universo[i, j] = cTemp;
                }
            }
        }

        // contacts
       private void fillRandXNum(int no, int stat, int latent) {

            int j = 0;
            
                while(j < no)
                {
                    int eX = r.Next(0, 140);
                    int eY = r.Next(0, 140);
                    Cell tmp = universo[eX, eY];
                    
                    //restriccion solo con celulas con diferente status
                    // restriccion de vaccinados pero en infectados no afecta a vaccinados
                    if (stat == 3)
                    {
                        if (tmp.getCellStatus() != stat && tmp.getCellStatus() < 5)
                            {
                     
                                universo[eX, eY] = new Cell(stat, latent);
                                j++;

                            }
                    }
                    else if (tmp.getCellStatus() != stat)
                    {
                                universo[eX, eY] = new Cell(stat, latent);
                                j++;

                    }
                    tmp = null;
                }
        }

        //Inicialize
        private void fillBlank() {

            int i, j;
            
            for (i = 0; i < 140; i++)
            {
                for (j = 0; j < 140; j++)
                {
                    universo[i, j] = new Cell();
                }
            }

        }

        //Visualiza toda la matriz
        private void drawMatrix() {

            int x, y;
            Cell temp;
            Brush color = null;

            for (x = 1; x <= 560; x += 4)
            {
                for (y = 1; y <= 560; y += 4)
                {
                    temp = universo[x / 4, y / 4];
                    
                    if (temp.getCellStatus() == 1)
                    {
                        color = Brushes.Blue;
                    }
                    else if (temp.getCellStatus() == 2)
                    {
                        color = Brushes.Green;
                    }
                    else if (temp.getCellStatus() == 3)
                    {
                        color = Brushes.Yellow;
                    }
                    else if (temp.getCellStatus() == 4)
                    {
                        color = Brushes.Brown;
                    }
                    else if (temp.getCellStatus() == 5)
                    {
                        color = Brushes.SkyBlue;
                    }
                    else if (temp.getCellStatus() == 6)
                    {
                        color = Brushes.Black;
                    }

                    g.FillRectangle(color, x, y, 4, 4);

                }
            }
        }


        //boton inicializar
        private void button2_Click(object sender, EventArgs e)
        {

            r = new Random(conf.seed);
            
            pictureBox1.Refresh();
            this.fillBlank();
            this.showConfData();
            this.showStatics();
            this.lStatics = new List<Statics>();
            this.drawMatrix();
            // pintamos la matriz
            pictureBox1.Image = saveGraph;
            label1.Text = "";

            go.Enabled = true;
        }

        //boton salir
        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // boton paso por paso
        private void update_Click(object sender, EventArgs e)
        {
            update.Enabled = false;
            this.fillbyTime();
            this.showConfData();
            this.cellSorter();
            this.showStatics();
            this.drawMatrix();
            pictureBox1.Image = saveGraph;
            update.Enabled = true;

        }
        
        //pause
        private void pause_Click(object sender, EventArgs e)
        {

            playCtl = false;
            pause.Enabled = false;
            go.Enabled = true;

        }

        //control del putero que pinta
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint) {

                this.Cursor = new Cursor(Cursor.Current.Handle);

                int y = (Cursor.Position.Y - this.Location.Y) - 42;
                int x = (Cursor.Position.X - this.Location.X) - 20;
    
                this.drawPointMatrix(x, y);

            }
            

        }

        // actualiza la matriz con el puntero
        private void drawPointMatrix(int x,int y)
        {
            int period = 0;

            if (conf.pointerSel == 3)
            {
                g.FillRectangle(Brushes.Yellow, x, y, 4, 4);

                period = conf.infectiousP;

            }
            else if (conf.pointerSel == 5)
            {
                g.FillRectangle(Brushes.SkyBlue, x, y, 4, 4);

            }
            else if (conf.pointerSel == 6)
            {
                g.FillRectangle(Brushes.Black, x, y, 4, 4);
            }
        
            universo[x / 4, y / 4] = new Cell(conf.pointerSel,period);
            //pintamos en la matriz
            pictureBox1.Image = saveGraph;
                
        }

        //activa el puntero
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;

        }
        //desactiva el puntero
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }
        
        //Selecciona el tipo de puntero
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            conf.pointerSel = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            conf.pointerSel = 5;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            conf.pointerSel = 6;
        }


        //Botones que setean los parametros
        private void lambda_Click(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("Contacts Rate: ");
            iw.ShowDialog();
            conf.avgContacts = int.Parse(iw.campo);
            this.showConfData();
        }
        
        private void transmissionprob_Click(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("Transmission Prob: ");
            iw.ShowDialog();
            conf.transmissionProb = double.Parse(iw.campo);
            this.showConfData();

        }
        
        private void infect_Click(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("How many Infected:");
            iw.ShowDialog();
            int temp = int.Parse(iw.campo);
            this.fillRandXNum(temp, 3, conf.infectiousP);
            this.drawMatrix();
            //pintamos en la matriz
            pictureBox1.Image = saveGraph;
            
        }
        
        private void vaccine_Click(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("How many Vaccineted:");
            iw.ShowDialog();
            int temp =  int.Parse(iw.campo);
            this.fillRandXNum(temp, 5, 1);
            this.drawMatrix();
            //pintamos en la matriz
            pictureBox1.Image = saveGraph;
            
        }

        private void remove_Click(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("How many people you want to Remove:");
            iw.ShowDialog();
            int temp =  int.Parse(iw.campo);
            this.fillRandXNum(temp, 6, 1);
            this.drawMatrix();
            //pintamos en la matriz
            pictureBox1.Image = saveGraph;
            
        }

        private void latent_Click(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("Latent period (tl):");
            iw.ShowDialog();
            conf.latentP = int.Parse(iw.campo);
            this.showConfData();
        }

        private void infectious_Click(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("Inf period (ti):");
            iw.ShowDialog();
            conf.infectiousP = int.Parse(iw.campo);
            this.showConfData();
        }

        private void recovery_Click(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("Recover period (tr):");
            iw.ShowDialog();
            conf.recoveriP = int.Parse(iw.campo);
            this.showConfData();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            InputWindow iw = new InputWindow();
            iw.start("Random Seed:");
            iw.ShowDialog();
            conf.seed = int.Parse(iw.campo);
            this.showConfData();
        }

        
        // Control de los radios del tipo de modelo SIS = 1  SIR = 2   
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            conf.model = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            conf.model = 2;
        }

        // metodo para visualiar el resumen
        private void showConfData() {

            label2.Text = " Seed:                " + conf.seed.ToString() + Environment.NewLine +
                          " Contact Rate:        " + conf.avgContacts.ToString() + Environment.NewLine +
                          " Transmission Prob:   " + conf.transmissionProb.ToString() + Environment.NewLine +
                          " Latent Period: (tl)  " + conf.latentP.ToString() + Environment.NewLine +
                          " Inf. Period: (ti)    " + conf.infectiousP.ToString() + Environment.NewLine +
                          " Rec. Period: (tr)    " + conf.recoveriP.ToString() + Environment.NewLine +
                          " Model: " + conf.model.ToString() + Environment.NewLine +
                          " ";
      
        }

        private void showStatics()
        {
            label1.Text = " Suseptible:      " + statics.susceptible.ToString() + Environment.NewLine +
                          " Latent:          " + statics.latent.ToString() + Environment.NewLine +
                          " Infectious:      " + statics.infectious.ToString() + Environment.NewLine +
                          " Recovery:        " + statics.recovery.ToString() + Environment.NewLine +
                          " Vaccinated:      " + statics.vaccinated.ToString() + Environment.NewLine +
                          " Removed:         " + statics.removed.ToString() + Environment.NewLine +
                          " Times:         " + lStatics.Count.ToString() + Environment.NewLine +
                          " Total:   19,600";

        }

        private void cellSorter() {

            int i, j;
            statics = new Statics();

            for (i = 0; i < 140; i++)
            {
                for (j = 0; j < 140; j++)
                {
                    Cell cell = universo[i, j];

                    if (cell.getCellStatus() == 1) { statics.susceptible +=1;
                        
                    }else if (cell.getCellStatus() == 2) { statics.latent +=1;

                    }else if (cell.getCellStatus() == 3) { statics.infectious += 1;

                    }else if (cell.getCellStatus() == 4) { statics.recovery += 1;

                    }else if (cell.getCellStatus() == 5) { statics.vaccinated += 1;

                    }else if (cell.getCellStatus() == 6) { statics.removed += 1;

                    } 
                    
                }
            }

            //saving statics
            lStatics.Add(statics);
                        
        }
        
        //ploting tool
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.setData(lStatics);
            f2.ShowDialog();

        }

        private void vacStrategies(int restriction, int amount)
        {
            if (!((statics.susceptible + statics.latent) < amount))
            {
                if (this.typeStrategie == 1)
                {
                    if ((lStatics.Count % restriction) == 0)
                    {
                        this.fillRandXNum(amount, 5, 0);
                    }
                }
                else if (this.typeStrategie == 2)
                {
                    if (statics.infectious >= restriction)
                    {
                        this.fillRandXNum(amount, 5, 0);
                    }

                }

            }
        }


        // control del thread en background
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (playCtl)
            {
                this.fillbyTime();
                this.cellSorter();
                this.drawMatrix();
                backgroundWorker1.ReportProgress(1);
                
                //vaccination strategies
                if(this.stActive == true){
                    vacStrategies(int.Parse(noSchedulingOp.Text), int.Parse(perVacScheduling.Text));
                }
                // loop control
                if (statics.infectious == 0 && statics.latent == 0)
                {
                    playCtl = false;
                }
            }
        }
        //updates the interface
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //pintamos la matrix
            pictureBox1.Image = saveGraph;


            label1.Text = " Suseptible:      " + statics.susceptible.ToString() + Environment.NewLine +
                      " Latent:          " + statics.latent.ToString() + Environment.NewLine +
                      " Infectious:      " + statics.infectious.ToString() + Environment.NewLine +
                      " Recovery:        " + statics.recovery.ToString() + Environment.NewLine +
                      " Vaccinated:      " + statics.vaccinated.ToString() + Environment.NewLine +
                      " Removed:         " + statics.removed.ToString() + Environment.NewLine +
                      " Times:         " + lStatics.Count.ToString() + Environment.NewLine +
                      " Total:   19,600";

        }

        //play
        private void go_Click(object sender, EventArgs e)
        {
            go.Enabled = false;
            pause.Enabled = true;
            playCtl = true;
            backgroundWorker1.RunWorkerAsync();
        }

        //Button Save Img
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap Image|*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                saveGraph.Save(dialog.FileName, ImageFormat.Bmp);
          
            }
        }

              

        private void getFromFileBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML File|*.xml";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                Util ut = new Util();

                conf = ut.readXML(dialog.FileName);
                this.showConfData();
            }



        }

        private void saveConf_Click(object sender, EventArgs e)
        {

            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML File|*.xml";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                Util ut = new Util();

                ut.writeXML(dialog.FileName, conf);
            
            }

        }

        private void checkScheduling_CheckedChanged(object sender, EventArgs e)
        {

            if (this.stActive == true)
            {

                stActive = false;

            }
            else
            {

                stActive = true;

            }

        }

        private void radioTime_CheckedChanged(object sender, EventArgs e)
        {

            typeStrategie = 1;

        }

        private void radioTrigger_CheckedChanged(object sender, EventArgs e)
        {
            typeStrategie = 2;
        }
         
    }

       
    
}
