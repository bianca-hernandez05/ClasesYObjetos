using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAcademico
{
    public partial class Alumno
    {
        public string Nombre { get; set; }  
        public int Edad {  get; set; }
        public string Carne {  get; set; }
        public Carreras Carrera { get; set; }
        public List<double> Calificaciones { get; set; }

        public Alumno (string nombre, int edad, Carreras carrera, string carne)
        {
           this.Nombre = nombre;
           this.Edad = edad;
           this.Carrera = carrera;
           this.Carne = carne;  
           Calificaciones = new List<double> ();
        }

        public enum Carreras
        {
            Ingenieria_de_Sistemas,
            Ingenieria_en_Computacion,
            Telecomunicaciones,
            Ingenieria_Electronica
        }
        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;
            }

            double sumaCalificaciones = 0;

            foreach (var calificacion in Calificaciones)
            {
                sumaCalificaciones += calificacion;
            }
            return sumaCalificaciones / Calificaciones.Count;

        }

        public string EstadoAprobacion()
        {
            double promedio = CalcularPromedioCalificaciones();

            if (promedio >= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre del estudiante : {Nombre}");
            Console.WriteLine($"Edad del estudiante : {Edad}");
            Console.WriteLine($"Carrera del estudiante : {Carrera}");
            Console.WriteLine($"Numero de carnet del estudiante : {Carne}");
            Console.Write("Calificaciones del estudiante: ");

           // utilice un foreach para que me muestre las notas que se ingresaron en mi programa y luego saco el promedio 
            foreach (var calificacion in Calificaciones)
            {
                Console.Write($"{calificacion} - ");
            }
            Console.WriteLine();
            Console.WriteLine("Promedio del estudiante :" + CalcularPromedioCalificaciones());
            Console.WriteLine($"Estado de aprobacion :" + EstadoAprobacion());
            Console.WriteLine();

        }
    }
}
