using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Calculator_Actualizacion
{
    public partial class Home_Calculator : Form
    {
        int diasemana = 0;
        double horaingreso = 0;
        double horasalida = 0;
        double ordinaria = 0;
        double nocturna = 0;
        double festiva = 0;
        double festivanocturna = 0;
        

        public Home_Calculator()
        {
            
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            errorguardar.Visible = false;
            diasemana = int.Parse(textBoxdiasemana.Text);
            if (diasemana > 7 || diasemana < 1)
                labelcoregirdia.Visible = true;
            else
            {
                labelcoregirdia.Visible = false;
                mostra();
            }

            
        }

        private void textBoxdiasemana_TextChanged(object sender, EventArgs e)
        {
            if (textBoxdiasemana.Text != "")
                buttonsiguiente.Enabled = true;
            else
                buttonsiguiente.Enabled = false;

        }

        public void mostra()
        {
            labelhoraingr.Enabled = true;
            labelhorasali.Enabled = true;
            textBoxhoraingreso.Enabled = true;
            textBoxhorasalida.Enabled = true;
          
        }

        public void ocultar()
        {
            labelhoraingr.Enabled = false;
            labelhorasali.Enabled = false;
            textBoxhoraingreso.Enabled = false;
            textBoxhorasalida.Enabled = false;
            buttonguardar.Enabled = false;
            labelcorregirhoras.Visible = false;
        }

        private void textBoxhorasalida_TextChanged(object sender, EventArgs e)
        {
            if (textBoxhoraingreso.Text != "" && textBoxhorasalida.Text != "")
                buttonguardar.Enabled = true;
            else
                buttonguardar.Enabled = false;
        }

        private void textBoxhoraingreso_TextChanged(object sender, EventArgs e)
        {
            if (textBoxhoraingreso.Text != "" && textBoxhorasalida.Text != "")
                buttonguardar.Enabled = true;
            else
                buttonguardar.Enabled = false;
        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            labelcalcular.Text = "Su pago es:" + calcular(ordinaria, nocturna, festiva, festivanocturna);
            labelcalcular.Visible = true;
        }

        public void vaciartextbox()
        {
            textBoxdiasemana.Clear();
            textBoxhoraingreso.Clear();
            textBoxhorasalida.Clear();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            horaingreso = double.Parse(textBoxhoraingreso.Text);
            horasalida = double.Parse(textBoxhorasalida.Text);

            if ((horasalida - horaingreso) < 0.15)
                labelcorregirhoras.Visible = true;
            else
            {
                Guardar(diasemana, horaingreso, horasalida);
                ocultar();
                vaciartextbox();
            }
        }

        public void Guardar(int dia, double hi, double hs)
        {
            if (dia == 3)
            {
                if (hi >= 6 && hs <=21)
                {
                    festiva += hs - hi;
                }

                if (hi >=6 && hi<21 && hs>21)
                {
                    festivanocturna += hs - 21;
                    festiva += 21 - hi;

                }

                if (hi < 6 && hs >6 && hs<=21)
                {
                    festivanocturna += (6 - hi);
                    festiva += hs - 6;
                }

                if (hi<6 && hs>21)
                {
                    festivanocturna += (6 - hi);
                    festiva += (hs - 6) - (hs - 21);
                    festivanocturna += (hs - 21);
                }

                if (hi >= 21)
                {
                    festivanocturna += hs - hi;
                }

                if (hi >= 0 && hs <= 6)
                {
                    festivanocturna += hs - hi;
                }

            }
            else if (dia != 3)
            {
                if (hi >= 6 && hs <= 21)
                {
                    ordinaria += hs - hi;
                }

                if (hi >= 6 && hi <21 && hs > 21)
                {
                    nocturna += hs - 21;
                    ordinaria += 21 - hi;

                }

                if (hi < 6 && hs > 6 && hs <= 21)
                {
                    nocturna += (6 - hi);
                    ordinaria += hs - 6;
                }

                if (hi < 6 && hs > 21)
                {
                    nocturna += (6 - hi);
                    ordinaria += (hs - 6) - (hs - 21);
                    nocturna += (hs - 21);
                }

                if (hi>=21 )
                {
                    nocturna += hs - hi;
                }

                if(hi>=0 && hs<=6)
                {
                    nocturna += hs - hi;
                }
            }
            else
                errorguardar.Visible = true;
            
        }

        public double calcular(double ord, double noct, double fest, double festnoc)
        {
            double pago=0;
            pago += (ord * 6100);
            pago += (noct * 8156);
            pago += (fest * 10672);
            pago += (festnoc * 12809);
            return pago;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(borrardatos())
            {
                MessageBox.Show("Datos borrados con exito");
            }
        }

        public bool borrardatos()
        {
            festivanocturna = 0;
            nocturna = 0;
            ordinaria = 0;
            festiva = 0;
            return true;
        }
    }
}
