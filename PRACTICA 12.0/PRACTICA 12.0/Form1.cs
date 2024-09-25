using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_12._0
{
    public partial class Form1 : Form
{
    // Instanciar la clase VentasData
    VentasData ventasData = new VentasData();

    public Form1()
    {
        InitializeComponent();
        ConfigurarDataGridView(); // Configura las columnas del DataGridView
        CargarDatosEnDataGridView(); // Carga los datos en el DataGridView
    }

    // Configurar las columnas del DataGridView
    private void ConfigurarDataGridView()
    {
        // Asignar nombres a las columnas para los días de la semana
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

        dataGridViewVentas.ColumnCount = 5; // Número de días de la semana

        for (int i = 0; i < dias.Length; i++)
        {
            dataGridViewVentas.Columns[i].Name = dias[i];
        }
    }

    // Cargar los datos en el DataGridView
    private void CargarDatosEnDataGridView()
    {
        // Obtener la matriz de ventas
        int[,] ventas = ventasData.GetVentas();

        // Limpiar las filas actuales si existen
        dataGridViewVentas.Rows.Clear();

        // Iterar sobre las filas y columnas de la matriz y agregar los datos al DataGridView
        for (int i = 0; i < ventas.GetLength(0); i++) // Iterar sobre los meses (filas)
        {
            string[] fila = new string[7]; // Crear una fila con 7 columnas (días de la semana)

            for (int j = 0; j < ventas.GetLength(1); j++) // Iterar sobre los días de la semana (columnas)
            {
                fila[j] = ventas[i, j].ToString(); // Asignar el valor de la matriz a la fila
            }

            // Añadir la fila al DataGridView
            dataGridViewVentas.Rows.Add(fila);
        }
    }

        private void dataGridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Llamar a los métodos recursivos de la clase VentasData
            var menor = ventasData.MenorVenta();
            var mayor = ventasData.MayorVenta();
            int totalVentas = ventasData.VentaTotal();
            int[] ventasPorDia = ventasData.VentasPorDia();

            // Actualizar los labels con los resultados
            lblMenorVenta.Text = $"Menor venta: {menor.Item1} en Mes {menor.Item2}, Día {menor.Item3}";
            lblMayorVenta.Text = $"Mayor venta: {mayor.Item1} en Mes {mayor.Item2}, Día {mayor.Item3}";
            lblVentaTotal.Text = $"Total de ventas: {totalVentas}";

            // Crear una cadena con las ventas por día de la semana
            string ventasPorDiaMensaje = "Ventas por día:\n";
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            for (int i = 0; i < ventasPorDia.Length; i++)
            {
                ventasPorDiaMensaje += $"{dias[i]}: {ventasPorDia[i]}\n";
            }
            lblVentasPorDia.Text = ventasPorDiaMensaje;
        }


    }

}
