using System;
using System.Collections.Generic;

namespace BuscadorAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Francisco = new Alumno("Francisco", 31, false, new List<float> { 8, 9, 7, 8, 6 }, 176);
            Alumno Alejandro = new Alumno("Alejandro", 12, true, new List<float>{ 7, 6, 4, 8, 6 }, 164);
            Alumno Leandro = new Alumno("Leandro", 1, true, new List<float> { 8, 7, 6, 5, 9 }, 184);
            Alumno Sharon = new Alumno("Sharon", 2, false, new List<float> { 9, 6, 6, 8, 7 }, 170);
            Alumno Kenet = new Alumno("Kenet", 3, true, new List<float> { 10, 9, 9, 7, 8 }, 153);

            BuscadorDeAlumnos buscador = new BuscadorDeAlumnos();
            List<Alumno> alumnos = new List<Alumno> {Francisco, Alejandro, Leandro, Sharon, Kenet };
            buscador.Interfaz(alumnos);

        }
    }
}
