using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_13
{
    public class Alumno
    {
        public double[] Calificaciones { get; private set; }

        public Alumno(double[] calificaciones)
        {
            Calificaciones = calificaciones;
        }

        // Método recursivo para calcular el promedio
        public double ObtenerPromedio()
        {
            return CalcularPromedioRecursivo(Calificaciones, Calificaciones.Length, 0);
        }

        // Método recursivo que suma los valores de las calificaciones y luego calcula el promedio
        private double CalcularPromedioRecursivo(double[] calificaciones, int n, double suma)
        {
            if (n == 0)
                return suma / Calificaciones.Length;
            return CalcularPromedioRecursivo(calificaciones, n - 1, suma + calificaciones[n - 1]);
        }

        public int ObtenerReprobadas()
        {
            return Calificaciones.Count(cal => cal < 7.0);
        }
    }

}
