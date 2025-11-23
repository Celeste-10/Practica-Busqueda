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
    public partial class Ejercicio6 : Form
    {
        int[,] matriz = new int[10, 10];
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            dgvMatriz.Columns.Clear();
            dgvMatriz.Rows.Clear();

            // Crear 10 columnas
            for (int c = 0; c < 10; c++)
            {
                dgvMatriz.Columns.Add($"C{c}", $"C{c}");
                dgvMatriz.Columns[c].Width = 40; // para que no se vea grande
            }

            // Crear 10 filas
            dgvMatriz.Rows.Add(10);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = r.Next(1, 100);
                    dgvMatriz.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
            MessageBox.Show("Matriz 10x10 generada correctamente");
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        lblResultado.Text = $"Encontrado en fila {i}, columna {j}.";
                        return;
                    }
                }
            }

            lblResultado.Text = "Número NO encontrado.";
        }
    }
}
