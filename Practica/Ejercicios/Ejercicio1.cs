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
    public partial class Ejercicio1 : Form
    {
        int[] arreglo = new int[20];
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < arreglo.Length; i++)
                arreglo[i] = r.Next(1, 100);

            lstArreglo.Items.Clear();
            foreach (var n in arreglo)
                lstArreglo.Items.Add(n);

            lblResultado.Text = "Arreglo generado.";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            bool encontrado = false;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == numero)
                {
                    lblResultado.Text = $"Número encontrado en la posición {i}.";
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                lblResultado.Text = "El número NO existe en el arreglo.";
        }
    }
}
