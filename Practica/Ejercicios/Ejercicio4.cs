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
    public partial class Ejercicio4 : Form
    {
        List<Estudiante> estudiantes;
        public Ejercicio4()
        {
            InitializeComponent();
            CargarEstudiantes();
        }
        private void CargarEstudiantes()
        {
            // Lista con 10 estudiantes
            estudiantes = new List<Estudiante>()
            {
                new Estudiante { Id = 1, Nombre = "Ana" },
                new Estudiante { Id = 2, Nombre = "Brenda" },
                new Estudiante { Id = 3, Nombre = "Carlos" },
                new Estudiante { Id = 4, Nombre = "Daniel" },
                new Estudiante { Id = 5, Nombre = "Elena" },
                new Estudiante { Id = 6, Nombre = "Fernanda" },
                new Estudiante { Id = 7, Nombre = "Gabriel" },
                new Estudiante { Id = 8, Nombre = "Hector" },
                new Estudiante { Id = 9, Nombre = "Iván" },
                new Estudiante { Id = 10, Nombre = "Julia" },
            };
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            
        }
        private Estudiante BusquedaLineal(int id)
        {
            foreach (var est in estudiantes)
            {
                if (est.Id == id)
                    return est;
            }
            return null;
        }
        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor ingresa un número.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (!int.TryParse(txtId.Text, out int idBuscado))
            {
                lblResultadoId.Text = "Ingrese un ID válido.";
                return;
            }

            Estudiante encontrado = BusquedaLineal(idBuscado);

            if (encontrado != null)
                lblResultadoId.Text = $"Encontrado: {encontrado.Id} - {encontrado.Nombre}";
            else
                lblResultadoId.Text = "No se encontró el estudiante.";
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingresa un número.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            string nombreBuscado = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombreBuscado))
            {
                lblResultadoNombre.Text = "Ingrese un nombre.";
                return;
            }

            var listaOrdenada = estudiantes.OrderBy(x => x.Nombre).ToList();

            Estudiante encontrado = BusquedaBinaria(listaOrdenada, nombreBuscado);

            if (encontrado != null)
                lblResultadoNombre.Text = $"Encontrado: {encontrado.Id} - {encontrado.Nombre}";
            else
                lblResultadoNombre.Text = "No se encontró el estudiante.";
        }

        private Estudiante BusquedaBinaria(List<Estudiante> lista, string nombre)
        {
            int inicio = 0;
            int fin = lista.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                int comparacion = string.Compare(lista[medio].Nombre, nombre, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    return lista[medio];
                }
                else if (comparacion < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return null;
        }
    }
}
