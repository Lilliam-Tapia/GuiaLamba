using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaLamba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiantes> listest = new List<Estudiantes>() {
            new Estudiantes("María", 18, 90),
            new Estudiantes("Juan", 19, 85),
            new Estudiantes("Ana", 18, 73),
            new Estudiantes("José", 21, 89),
            new Estudiantes("Rosa", 17, 70)
            };

            // Filtrar los estudiantes cuya edad es mayor a 18 años.

            var estudiantesMayoresDe18 = listest.Where(e => e.Edad > 18).ToList();
            Console.WriteLine("Estudiantes mayores de 18 años:");
            foreach (var estudiante in estudiantesMayoresDe18)
            {
                Console.WriteLine($"{estudiante.Nombre}, {estudiante.Edad} años, Nota: {estudiante.Nota}");
            }
            Console.WriteLine();

            //Obtener el estudiante con la nota más alta.

            var estudianteNotaMasAlta = listest.OrderByDescending(e => e.Nota).First();
            Console.WriteLine($"Estudiante con la nota más alta: {estudianteNotaMasAlta.Nombre}, Nota: {estudianteNotaMasAlta.Nota}");
            Console.WriteLine();

            // Ordenar la lista de estudiantes por nombre en orden

            var estudiantesOrdenadosPorNombre = listest.OrderBy(e => e.Nombre).ToList();
            Console.WriteLine("Estudiantes ordenados por nombre:");
            foreach (var estudiante in estudiantesOrdenadosPorNombre)
            {
                Console.WriteLine($"{estudiante.Nombre}, {estudiante.Edad} años, Nota: {estudiante.Nota}");
            }
            Console.WriteLine();

            double promedioNotas = listest.Average(e => e.Nota);

            Console.WriteLine($"Promedio de notas de los estudiantes:{promedioNotas}");
        }
    }
}
