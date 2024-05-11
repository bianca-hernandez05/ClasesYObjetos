using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAcademico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Universidad universidad = new Universidad();
           
            Alumno alumno = new Alumno("Bianca Danelia Hernandez Molina", 19, Alumno.Carreras.Ingenieria_de_Sistemas, "2023-090U");
            universidad.AgregarAlumno(alumno);
            alumno.Calificaciones.Add(70);
            alumno.Calificaciones.Add(85.50);
            alumno.Calificaciones.Add(90);

            Alumno alumno2 = new Alumno("Marian Guadalupe Hernandez Molina", 21, Alumno.Carreras.Ingenieria_en_Computacion, "2022-0845U");
            universidad.AgregarAlumno(alumno2);
            alumno2.Calificaciones.Add(50);
            alumno2.Calificaciones.Add(50);
            alumno2.Calificaciones.Add(26);

            Alumno alumno3 = new Alumno("Mario Enrique Velasquez Zelaya", 23, Alumno.Carreras.Telecomunicaciones, "2020-1032U");
            universidad.AgregarAlumno(alumno3);
            alumno3.Calificaciones.Add(100);
            alumno3.Calificaciones.Add(60);
            alumno3.Calificaciones.Add(60);

            Alumno alumno4 = new Alumno("Blanca Danelis Zelaya Perez", 17, Alumno.Carreras.Ingenieria_Electronica, "2024-2345U");
            universidad.AgregarAlumno(alumno4);
            alumno4.Calificaciones.Add(35);
            alumno4.Calificaciones.Add(58);
            alumno4.Calificaciones.Add(100);

            Console.WriteLine();
            alumno.MostrarInformacion(); //en el metodo Mostrarinformacion() mande a llamar todos los metodos declarados en las clases 
            
            Console.WriteLine();
            alumno2.MostrarInformacion();
           
            Console.WriteLine();
            alumno3.MostrarInformacion();
            
            Console.WriteLine();
            alumno4.MostrarInformacion();

            Console.WriteLine();
            Console.WriteLine("Lista de alumnos en el sistema uni : ");
            universidad.ObtenerListaAlumnos(); //utilizamos un metodo para que nos muestre lo que almacenamos en nuestro metodo de lista de alumnos  \\

            // en mi programa principal lo que hice fue no sobrecargar mucho con los metodos de las clases que se \\
        }
    }
}
