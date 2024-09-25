using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MatrixOperations
{
    private int[,] matrix;

    public MatrixOperations(int[,] matrix)
    {
        this.matrix = matrix;
    }

    // Método recursivo para calcular la suma de una fila
    public int SumRowRecursive(int row, int col)
    {
        if (col < 0)
            return 0;
        return matrix[row, col] + SumRowRecursive(row, col - 1);
    }

    // Método recursivo para calcular la suma de una columna
    public int SumColRecursive(int col, int row)
    {
        if (row < 0)
            return 0;
        return matrix[row, col] + SumColRecursive(col, row - 1);
    }

    // Método para calcular el promedio de una fila
    public double AverageRow(int row)
    {
        return (double)SumRowRecursive(row, matrix.GetLength(1) - 1) / matrix.GetLength(1);
    }

    // Método para calcular el promedio de una columna
    public double AverageCol(int col)
    {
        return (double)SumColRecursive(col, matrix.GetLength(0) - 1) / matrix.GetLength(0);
    }
}