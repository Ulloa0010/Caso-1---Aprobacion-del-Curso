using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_1___Aprobacion_del_Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string estudiante;
            float nota_tareas;
            float nota_proyecto;
            float nota_examen;

            Console.Write("Ingrese el nombre del estudiante: ");
            estudiante = Console.ReadLine();

            Console.Write("Ingrese la nota de tareas: ");
            while (!float.TryParse(Console.ReadLine(), out nota_tareas) || nota_tareas < 0 || nota_tareas > 100)
            {
                Console.WriteLine("Error: la nota debe ser un número entre 0 y 100.");
                Console.Write("Ingrese nuevamente la nota de tareas: ");
            }

            Console.Write("Ingrese la nota del proyecto: ");
            while (!float.TryParse(Console.ReadLine(), out nota_proyecto) || nota_proyecto < 0 || nota_proyecto > 100)
            {
                Console.WriteLine("Error: la nota debe ser un número entre 0 y 100.");
                Console.Write("Ingrese nuevamente la nota del proyecto: ");
            }

            Console.Write("Ingrese la nota del examen: ");
            while (!float.TryParse(Console.ReadLine(), out nota_examen) || nota_examen < 0 || nota_examen > 100)
            {
                Console.WriteLine("Error: la nota debe ser un número entre 0 y 100.");
                Console.Write("Ingrese nuevamente la nota del examen: ");
            }

            nota_tareas = nota_tareas * 0.20f;
            nota_proyecto = nota_proyecto * 0.30f;
            nota_examen = nota_examen * 0.50f;

            float nota_final = nota_tareas + nota_proyecto + nota_examen;

            Console.WriteLine("\n--- DESGLOSE DE NOTAS ---");
            Console.WriteLine($"Estudiante: {estudiante}");
            Console.WriteLine($"Aporte de tareas (20%): {nota_tareas}");
            Console.WriteLine($"Aporte de proyecto (30%): {nota_proyecto}");
            Console.WriteLine($"Aporte de examen (50%): {nota_examen}");
            Console.WriteLine($"Nota final: {nota_final}");

            if (nota_final >= 70)
            {
                Console.WriteLine($"{estudiante} aprobó con una nota final de: {nota_final}");
            }
            else
            {
                Console.WriteLine($"{estudiante} reprobó con una nota final de: {nota_final}");
            }
        }
    }
}