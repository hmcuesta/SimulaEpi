using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Imaging;
using System.IO;

namespace SimulaEpi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private List<Statics> lStatics;

        public void setData(Object list) {

            lStatics = (List<Statics>)list;
        
        }

        //boton guarda grafica en bmp
        private void button1_Click(object sender, EventArgs e)
        {
              SaveFileDialog dialog = new SaveFileDialog();
              dialog.Filter = "Bitmap Image|*.bmp";
   
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(dialog.FileName, ImageFormat.Bmp);
         
            }        
         }

        //boton muestra todos
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int cont = 1;

            chart1.Series.Clear();

            chart1.Series.Add("Susceptibles");
            chart1.Series["Susceptibles"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Infectious");
            chart1.Series["Infectious"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Latent");
            chart1.Series["Latent"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Recovered");
            chart1.Series["Recovered"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Vaccinated");
            chart1.Series["Vaccinated"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Removed");
            chart1.Series["Removed"].ChartType = SeriesChartType.FastLine;
            
            foreach (Statics c in lStatics)
            {

                chart1.Series["Susceptibles"].Points.AddXY(cont, c.susceptible);

                chart1.Series["Infectious"].Points.AddXY(cont, c.infectious);

                chart1.Series["Latent"].Points.AddXY(cont, c.latent);

                chart1.Series["Recovered"].Points.AddXY(cont, c.recovery);

                chart1.Series["Vaccinated"].Points.AddXY(cont, c.vaccinated);

                chart1.Series["Removed"].Points.AddXY(cont, c.removed);
                
                cont++;

            }

            chart1.Series["Susceptibles"].Color = Color.Blue;
            chart1.Series["Infectious"].Color = Color.Yellow;
            chart1.Series["Latent"].Color = Color.Green;
            chart1.Series["Recovered"].Color = Color.Brown;
            chart1.Series["Vaccinated"].Color = Color.SkyBlue;
            chart1.Series["Removed"].Color = Color.Black;

        }

        //boton exporta datos a cvs
        private void button2_Click(object sender, EventArgs e)
        {
   
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV File|*.csv";
            StringBuilder sb = new StringBuilder();  
            string delimiter = ",";  

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                foreach (Statics c in lStatics)
                {
                    sb.AppendLine(string.Join(delimiter, c.susceptible));
                    sb.AppendLine(string.Join(delimiter, c.latent));
                    sb.AppendLine(string.Join(delimiter, c.infectious));
                    sb.AppendLine(string.Join(delimiter, c.recovery));
                }

                File.WriteAllText(dialog.FileName, sb.ToString());

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int cont = 1;

            foreach (Statics c in lStatics)
            {

                chart1.Series["Susceptibles"].Points.AddXY(cont, c.susceptible);
                cont++;

            }

            chart1.Series["Susceptibles"].Color = Color.Blue;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int cont = 1;

            foreach (Statics c in lStatics)
            {

                chart1.Series["Latent"].Points.AddXY(cont, c.latent);
                cont++;

            }

            chart1.Series["Latent"].Color = Color.Green;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int cont = 1;

            foreach (Statics c in lStatics)
            {

                chart1.Series["Infectious"].Points.AddXY(cont, c.infectious);

                cont++;

            }

            chart1.Series["Infectious"].Color = Color.Yellow;


        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int cont = 1;

            foreach (Statics c in lStatics)
            {

                chart1.Series["Recovered"].Points.AddXY(cont, c.recovery);
                cont++;

            }
            chart1.Series["Recovered"].Color = Color.Brown;
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int cont = 1;

            foreach (Statics c in lStatics)
            {

                chart1.Series["Vaccinated"].Points.AddXY(cont, c.vaccinated);
                cont++;

            }
            chart1.Series["Vaccinated"].Color = Color.SkyBlue;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int cont = 1;

            foreach (Statics c in lStatics)
            {

                chart1.Series["Removed"].Points.AddXY(cont, c.removed);
                cont++;

            }
            
            chart1.Series["Removed"].Color = Color.Black;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            chart1.Series.Add("Susceptibles");
            chart1.Series["Susceptibles"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Infectious");
            chart1.Series["Infectious"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Latent");
            chart1.Series["Latent"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Recovered");
            chart1.Series["Recovered"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Vaccinated");
            chart1.Series["Vaccinated"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Removed");
            chart1.Series["Removed"].ChartType = SeriesChartType.FastLine;
            
        
        }


    }
}
