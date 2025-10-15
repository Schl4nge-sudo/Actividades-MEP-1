using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad_1_MP
{

    // Ejercicio 1 Practica 2
    internal class PorNombre : Strategy
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).Nombre == ((Alumno)c2).Nombre;
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return string.Compare(((Alumno)c1).Nombre.ToLower(), ((Alumno)c2).Nombre.ToLower()) > 0;
        }
        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return string.Compare(((Alumno)c1).Nombre.ToLower(), ((Alumno)c2).Nombre.ToLower()) < 0;
        }
    }
}
