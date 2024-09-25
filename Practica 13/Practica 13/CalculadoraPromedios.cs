using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_13
{
    public class CalculadoraPromedios
    {
        private List<Alumno> Alumnos;

        public CalculadoraPromedios(List<Alumno> alumnos)
        {
            Alumnos = alumnos;
        }

        public double ObtenerPromedioMayor()
        {
            return Alumnos.Max(alumno => alumno.ObtenerPromedio());
        }

        public double ObtenerPromedioMenor()
        {
            return Alumnos.Min(alumno => alumno.ObtenerPromedio());
        }

        public int ContarParcialesReprobados()
        {
            return Alumnos.Sum(alumno => alumno.ObtenerReprobadas());
        }

        // Método recursivo para distribuir las calificaciones finales
        public Dictionary<string, int> DistribuirCalificacionesFinales()
        {
            var distribucion = new Dictionary<string, int>
        {
            { "0 – 4.9", 0 },
            { "5.0 – 5.9", 0 },
            { "6.0 – 6.9", 0 },
            { "7.0 – 7.9", 0 },
            { "8.0 – 8.9", 0 },
            { "9.0 – 10", 0 }
        };

            // Llamada al método recursivo
            DistribuirRecursivo(Alumnos, 0, distribucion);

            return distribucion;
        }

        // Método recursivo para asignar a la distribución
        private void DistribuirRecursivo(List<Alumno> alumnos, int index, Dictionary<string, int> distribucion)
        {
            if (index == alumnos.Count)
                return;

            double promedio = alumnos[index].ObtenerPromedio();

            if (promedio < 5.0)
                distribucion["0 – 4.9"]++;
            else if (promedio < 6.0)
                distribucion["5.0 – 5.9"]++;
            else if (promedio < 7.0)
                distribucion["6.0 – 6.9"]++;
            else if (promedio < 8.0)
                distribucion["7.0 – 7.9"]++;
            else if (promedio < 9.0)
                distribucion["8.0 – 8.9"]++;
            else
                distribucion["9.0 – 10"]++;

            // Llamada recursiva con el siguiente índice
            DistribuirRecursivo(alumnos, index + 1, distribucion);
        }
    }
}
