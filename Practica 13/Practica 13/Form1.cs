using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_13
{
    public partial class Form1 : Form
    {
        private List<Alumno> alumnos;
        public Form1()
        {
            InitializeComponent();
            InicializarDatos();
            CargarDatosEnDataGridView();
        }

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InicializarDatos()
        {
            // Cargar los datos de la tabla en la lista de alumnos.
            alumnos = new List<Alumno>
            {
                new Alumno(new double[] { 5.5, 8.6, 10.0 }),
                new Alumno(new double[] { 8.0, 5.5, 10.0 }),
                new Alumno(new double[] { 9.0, 4.1, 7.8 }),
                new Alumno(new double[] { 10.0, 2.2, 8.1 }),
                new Alumno(new double[] { 7.0, 9.2, 7.1 }),
                new Alumno(new double[] { 9.0, 4.0, 6.0 }),
                new Alumno(new double[] { 6.5, 5.0, 5.0 }),
                new Alumno(new double[] { 4.0, 7.0, 4.0 }),
                new Alumno(new double[] { 8.0, 8.0, 9.0 }),
                new Alumno(new double[] { 10.0, 9.0, 9.2 }),
                new Alumno(new double[] { 5.0, 10.0, 8.4 }),
                new Alumno(new double[] { 9.0, 4.6, 7.5 })
            };
        }

        private void CargarDatosEnDataGridView()
        {
            // Crear las columnas del DataGridView
            dataGridViewAlumnos.Columns.Add("Parcial1", "Parcial 1");
            dataGridViewAlumnos.Columns.Add("Parcial2", "Parcial 2");
            dataGridViewAlumnos.Columns.Add("Parcial3", "Parcial 3");
            dataGridViewAlumnos.Columns.Add("Promedio", "Promedio");

            // Agregar las filas con las calificaciones y el promedio
            foreach (var alumno in alumnos)
            {
                double promedio = alumno.ObtenerPromedio();
                dataGridViewAlumnos.Rows.Add(alumno.Calificaciones[0], alumno.Calificaciones[1], alumno.Calificaciones[2], promedio.ToString("F2"));
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            CalculadoraPromedios calculadora = new CalculadoraPromedios(alumnos);

            // Mostrar los resultados en la interfaz gráfica.
            lblPromedioMayor.Text = "Promedio más alto: " + calculadora.ObtenerPromedioMayor().ToString("F2");
            lblPromedioMenor.Text = "Promedio más bajo: " + calculadora.ObtenerPromedioMenor().ToString("F2");
            lblParcialesReprobados.Text = "Parciales reprobados: " + calculadora.ContarParcialesReprobados().ToString();

            var distribucion = calculadora.DistribuirCalificacionesFinales();
            lblDistribucion.Text = string.Join(Environment.NewLine, distribucion.Select(d => $"{d.Key}: {d.Value} Alumnos"));
        }
    }
}
