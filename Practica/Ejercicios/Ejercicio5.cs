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
    public partial class Ejercicio5 : Form
    {
        List<int> lista = new List<int>();
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            lista.Clear();

            for (int i = 0; i < 20; i++)
                lista.Add(r.Next(1, 100));

            lstLista.Items.Clear();
            foreach (var n in lista)
                lstLista.Items.Add(n);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int max = lista[0];
            int min = lista[0];
            int iteraciones = 0;

            foreach (var n in lista)
            {
                if (n > max) max = n;
                if (n < min) min = n;
                iteraciones++;
            }

            lblMax.Text = $"Max: {max}";
            lblMin.Text = $"Min: {min}";
            lblIteraciones.Text = $"Iteraciones: {iteraciones}";
        }

        private void lblIteraciones_Click(object sender, EventArgs e)
        {

        }
    }
}
