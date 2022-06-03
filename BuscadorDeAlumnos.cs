using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorAlumnos
{
    class BuscadorDeAlumnos
    {
        public void Interfaz(List<Alumno> alumnos)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();
            this.MostrarLista(this.BuscarNombre(alumnos, nombre));

            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.WriteLine("Ingrese el numero de identificacion que busca (va a devolver a quien le pertenece el ID)");
            int numeroId = int.Parse(Console.ReadLine());
            this.MostrarLista(this.BuscarNumeroIdentificacion(alumnos, numeroId));

            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.WriteLine("Esta es la lista de los alumnos activos: ");
            bool alumnoActivo = true;
            this.MostrarLista(this.BuscarActividad(alumnos, alumnoActivo));

            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.WriteLine("Esta es la lista de los alumnos con promedio mayor a 7: ");
            float promedioNota = 7;
            this.MostrarLista(this.BuscarPromedio(alumnos, promedioNota));

            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.WriteLine("Esta es la lista de los alumnos de estatura mayor a 170 centimetros: ");
            int estaturAlumno = 170;
            this.MostrarLista(this.BuscarEstatura(alumnos, estaturAlumno));
        }

        public List<Alumno> BuscarNombre(List<Alumno> alumnos, string nombreAlumno)
        {
            List<Alumno> alumnosFiltrados = alumnos.Where(alumno => alumno.MostrarNombre() == nombreAlumno).ToList();
            return alumnosFiltrados;
        }

        public List<Alumno> BuscarNumeroIdentificacion(List<Alumno> alumnos, int numeroId)
        {
            List<Alumno> alumnosFiltrados = alumnos.Where(alumno => alumno.MostrarIdentificacion() == numeroId).ToList();
            return alumnosFiltrados;
        }

        public List<Alumno> BuscarActividad(List<Alumno> alumnos, bool alumnoActivo)
        {
            List<Alumno> alumnosFiltrados = alumnos.Where(alumno => alumno.MostrarActividad() == alumnoActivo).ToList();
            return alumnosFiltrados;
        }

        public List<Alumno> BuscarPromedio(List<Alumno> alumnos, float promedioAlumno)
        {
            List<Alumno> alumnosFiltrados = alumnos.Where(alumno => alumno.MostrarPromedio() >= promedioAlumno).ToList();
            return alumnosFiltrados;
        }

        public List<Alumno> BuscarEstatura(List<Alumno> alumnos, int estaturAlumno)
        {
            List<Alumno> alumnosFiltrados = alumnos.Where(alumno => alumno.MostrarEstatura() >= estaturAlumno).ToList();
            return alumnosFiltrados;
        }

        public void MostrarLista(List<Alumno> alumnos)
        {
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.MostrarNombre());
            }
        }




    }
}
