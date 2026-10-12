using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';   // ordinario por defecto
            int numPalabras = 0;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // ¿Telegrama urgente?
            if (cbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }

            // Número de palabras (VR 2026-27)
            numPalabras = textoTelegrama.Split(new char[] { ' ' },
                              StringSplitOptions.RemoveEmptyEntries).Length;

            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}
