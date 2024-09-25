using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_12._0
{
    public class VentasData
    {
        // Declarar la matriz de ventas
        private int[,] ventas = new int[12, 5]
        {
        { 5, 16, 10, 12, 24},    // Datos de la tabla
        { 40, 55, 10, 11, 18},
        { 15, 41, 78, 14, 51},
        { 35, 22, 81, 15, 12},
        { 50, 12, 71, 10, 20},
        { 70, 40, 60, 28, 22},
        { 50, 50, 50, 36, 25},
        { 40, 70, 40, 11, 20},
        { 20, 20, 30, 12, 18},
        { 10, 40, 32, 13, 16},
        { 50, 3, 24, 15, 82},
        { 40, 46, 15, 46, 22}
        };

        // Método para devolver los datos de ventas
        public int[,] GetVentas()
        {
            return ventas;
        }


        public (int, int, int) MenorVenta()
        {
            return MenorVentaRecursiva(0, 0, ventas[0, 0], 0, 0);
        }

        private (int, int, int) MenorVentaRecursiva(int mes, int dia, int menorActual, int mesMenor, int diaMenor)
        {
            if (mes == ventas.GetLength(0)) // Si llegamos al final de las filas
            {
                return (menorActual, mesMenor + 1, diaMenor + 1); // +1 para que los meses y días inicien en 1
            }

            if (dia == ventas.GetLength(1)) // Si llegamos al final de las columnas, pasar al siguiente mes
            {
                return MenorVentaRecursiva(mes + 1, 0, menorActual, mesMenor, diaMenor);
            }

            if (ventas[mes, dia] < menorActual) // Si encontramos un nuevo menor
            {
                menorActual = ventas[mes, dia];
                mesMenor = mes;
                diaMenor = dia;
            }

            return MenorVentaRecursiva(mes, dia + 1, menorActual, mesMenor, diaMenor); // Avanzar al siguiente día
        }

        public (int, int, int) MayorVenta()
        {
            return MayorVentaRecursiva(0, 0, ventas[0, 0], 0, 0);
        }

        private (int, int, int) MayorVentaRecursiva(int mes, int dia, int mayorActual, int mesMayor, int diaMayor)
        {
            if (mes == ventas.GetLength(0)) // Si llegamos al final de las filas
            {
                return (mayorActual, mesMayor + 1, diaMayor + 1); // +1 para que los meses y días inicien en 1
            }

            if (dia == ventas.GetLength(1)) // Si llegamos al final de las columnas, pasar al siguiente mes
            {
                return MayorVentaRecursiva(mes + 1, 0, mayorActual, mesMayor, diaMayor);
            }

            if (ventas[mes, dia] > mayorActual) // Si encontramos un nuevo mayor
            {
                mayorActual = ventas[mes, dia];
                mesMayor = mes;
                diaMayor = dia;
            }

            return MayorVentaRecursiva(mes, dia + 1, mayorActual, mesMayor, diaMayor); // Avanzar al siguiente día
        }

        public int VentaTotal()
        {
            return VentaTotalRecursiva(0, 0);
        }

        private int VentaTotalRecursiva(int mes, int dia)
        {
            if (mes == ventas.GetLength(0)) // Si llegamos al final de las filas
            {
                return 0; // No hay más ventas que sumar
            }

            if (dia == ventas.GetLength(1)) // Si llegamos al final de las columnas, pasar al siguiente mes
            {
                return VentaTotalRecursiva(mes + 1, 0);
            }

            return ventas[mes, dia] + VentaTotalRecursiva(mes, dia + 1); // Sumar la venta actual y avanzar al siguiente día
        }

        public int[] VentasPorDia()
        {
            int[] sumaPorDia = new int[ventas.GetLength(1)];
            return VentasPorDiaRecursiva(0, 0, sumaPorDia);
        }

        private int[] VentasPorDiaRecursiva(int mes, int dia, int[] sumaPorDia)
        {
            if (mes == ventas.GetLength(0)) // Si llegamos al final de las filas
            {
                return sumaPorDia; // Devuelve el resultado final
            }

            if (dia == ventas.GetLength(1)) // Si llegamos al final de las columnas, pasar al siguiente mes
            {
                return VentasPorDiaRecursiva(mes + 1, 0, sumaPorDia);
            }

            // Sumar la venta actual al día correspondiente
            sumaPorDia[dia] += ventas[mes, dia];

            return VentasPorDiaRecursiva(mes, dia + 1, sumaPorDia); // Avanzar al siguiente día
        }




    }

}
