using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAcademico
{
    public partial class Universidad
    {
        private List<Alumno> listaAlumnos;

        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        public List<Alumno> ObtenerListaAlumnos()
        {
            //utiice un foreach para poder llamar informacion guardada para que busque en mi lista de alumnos lo que tengo almacenado segun los alumnos que agregue

            foreach (Alumno alumno in listaAlumnos)
            {
                Console.WriteLine($"Nombre del alumno: {alumno.Nombre}, Carrera : {alumno.Carrera}, Numero de carnet: {alumno.Carne}");

            }
            return listaAlumnos;
        }

      
        }


    }

