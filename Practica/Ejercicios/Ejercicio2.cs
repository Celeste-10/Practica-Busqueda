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
    public partial class Ejercicio2 : Form
    {
        List<int> lista = new List<int>();
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            lista.Clear();
            for (int i = 0; i < 30; i++)
                lista.Add(r.Next(1, 100));

            lista.Sort(); 

            lstLista.Items.Clear();
            foreach (var n in lista)
                lstLista.Items.Add(n);

            lstProceso.Items.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Por favor ingresa un número.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int numero = int.Parse(txtNumero.Text);
            int inicio = 0;
            int fin = lista.Count - 1;

            lstProceso.Items.Clear();

            while (inicio <= fin)
            {
                int mitad = (inicio + fin) / 2;
                lstProceso.Items.Add($"Mitad: {mitad} (valor: {lista[mitad]})");

                if (lista[mitad] == numero)
                {
                    lstProceso.Items.Add("Número encontrado.");
                    return;
                }

                if (numero < lista[mitad])
                    fin = mitad - 1;
                else
                    inicio = mitad + 1;
            }

            lstProceso.Items.Add("Número NO encontrado.");
        }
    }
}
