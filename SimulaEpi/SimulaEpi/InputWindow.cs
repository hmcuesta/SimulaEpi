using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimulaEpi
{
    public partial class InputWindow : Form
    {
        public InputWindow( )
        {
            InitializeComponent();
        }

        public string campo = "0";

        public void start(String txtBtn) {

            labelInput.Text = txtBtn;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            campo = "0";
            this.Close();
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            campo = this.textBox1.Text;
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {

                campo = this.textBox1.Text;
                this.Close();

            }
        }

    }
}
