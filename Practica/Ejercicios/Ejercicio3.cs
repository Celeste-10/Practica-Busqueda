using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.Ejercicios
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPalabra.Text))
            {
                MessageBox.Show("Por favor ingresa un número.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            string texto = txtParrafo.Text.ToLower();
            string palabra = txtPalabra.Text.ToLower();

            int contador = 0;

            for (int i = 0; i < texto.Length - palabra.Length + 1; i++)
            {
                int j;
                for (j = 0; j < palabra.Length; j++)
                {
                    if (texto[i + j] != palabra[j])
                        break;
                }

                if (j == palabra.Length)
                    contador++;
            }

            lblResultado.Text = $"La palabra aparece {contador} veces.";
        }
    }
}
