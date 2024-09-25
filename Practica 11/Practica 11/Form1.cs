using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_11
{
    public partial class Form1 : Form
    {
        int[,] matrix = new int[5, 10]; // Matriz de 5x10
        MatrixOperations matrixOps;

        public Form1()
        {
            InitializeComponent();
        }

        private void Fila1_columna1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila1_columna10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila2_columna10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila3_columna10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila4_columna10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fila5_columna10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suma_columna1_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna2_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna3_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna4_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna5_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna6_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna7_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna8_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna9_Click(object sender, EventArgs e)
        {

        }

        private void Suma_columna10_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna1_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna2_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna3_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna4_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna5_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna6_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna7_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna8_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna9_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_columna10_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_fila1_Click(object sender, EventArgs e)
        {

        }

        private void Suma_fila2_Click(object sender, EventArgs e)
        {

        }

        private void Suma_fila3_Click(object sender, EventArgs e)
        {

        }

        private void Suma_fila4_Click(object sender, EventArgs e)
        {

        }

        private void Suma_fila5_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_fila2_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_fila3_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_fila4_Click(object sender, EventArgs e)
        {

        }

        private void Promedio_fila5_Click(object sender, EventArgs e)
        {

        }

        private void Suma_fila1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularResultados();
        }

        private void CalcularResultados()
        {
            // Llenar la matriz con los valores ingresados
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string textBoxName = "Fila" + (i + 1) + "_columna" + (j + 1);
                    TextBox textBox = this.Controls[textBoxName] as TextBox;
                    if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        matrix[i, j] = int.Parse(textBox.Text);
                    }
                    else
                    {
                        matrix[i, j] = 0; // Si está vacío, ponemos 0
                    }
                }
            }

            // Crear instancia de MatrixOperations
            matrixOps = new MatrixOperations(matrix);

            // Calcular y mostrar los resultados por fila
            for (int i = 0; i < 5; i++)
            {
                string sumRowLabelName = "Suma_fila" + (i + 1);
                Label sumRowLabel = this.Controls[sumRowLabelName] as Label;
                sumRowLabel.Text = matrixOps.SumRowRecursive(i, 9).ToString(); // Suma de la fila

                string avgRowLabelName = "Promedio_fila" + (i + 1);
                Label avgRowLabel = this.Controls[avgRowLabelName] as Label;
                avgRowLabel.Text = matrixOps.AverageRow(i).ToString("F2"); // Promedio de la fila
            }

            // Calcular y mostrar los resultados por columna
            for (int j = 0; j < 10; j++)
            {
                string sumColLabelName = "Suma_columna" + (j + 1);
                Label sumColLabel = this.Controls[sumColLabelName] as Label;
                sumColLabel.Text = matrixOps.SumColRecursive(j, 4).ToString(); // Suma de la columna

                string avgColLabelName = "Promedio_columna" + (j + 1);
                Label avgColLabel = this.Controls[avgColLabelName] as Label;
                avgColLabel.Text = matrixOps.AverageCol(j).ToString("F2"); // Promedio de la columna
            }
        }


    }
}
