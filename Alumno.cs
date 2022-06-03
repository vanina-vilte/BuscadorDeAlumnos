using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorAlumnos
{
    class Alumno
    {
        //Atributos
        private string nombre;
        private int numeroDeIdentificacion;
        private bool activo;
        private List<float> notas;
        private int estatura;
        private float promedioDeNotas;
        

        // Constructor
        public Alumno(string nombre, int numeroDeIdentificacion, bool activo, List<float> notas, int estatura)
        {
            this.nombre = nombre;
            this.numeroDeIdentificacion = numeroDeIdentificacion;
            this.activo = activo;
            this.notas = notas;
            this.estatura = estatura;
            this.promedioDeNotas = Promedio(notas);
        }

        //Metodos
        private float Promedio(List<float> notas)
        {
            float promedioDeNotas = notas.Average();
            return promedioDeNotas;
        }

        public float MostrarPromedio()
        {
            return this.promedioDeNotas;
        }

        public List<float> MostrarNotas()
        {
            return this.notas;
        }

        public int MostrarIdentificacion()
        {
            return this.numeroDeIdentificacion;
        }

        public bool MostrarActividad()
        {
            return this.activo;
        }

        public string MostrarNombre()
        {
            return this.nombre;
        }

        public int MostrarEstatura()
        {
            return this.estatura;
        }
    }
}
