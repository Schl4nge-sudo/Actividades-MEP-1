using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_MP
{
    // Ejercicio 1 Practica 2
    internal class PorLegajo : Strategy
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() == ((Alumno)c2).getLegajo();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).sosMayor(c2);
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).sosMenor(c2);

        }
    }
}
