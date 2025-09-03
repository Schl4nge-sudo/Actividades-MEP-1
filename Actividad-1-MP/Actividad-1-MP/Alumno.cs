using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_MP
{
    //Ejercicio 12 - Implementar alumno como subclase de persona
    internal class Alumno : Persona
    {
        Numero legajo;
        Numero promedio;
        public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
        {
           this.legajo = l;
           this.promedio = p;
        }

        public Numero getLegajo() {  return this.legajo; }
        public Numero getPromedio() { return this.promedio; }

        public bool sosIgual(Comparable c)
        {
            if (c.sosIgual(this.legajo))
            {
                return true;
            }
            return false;
        }

        public bool sosMayor(Comparable c)
        {
            if (c.sosMayor(this.legajo))
            {
                return true;
            }
            return false;
        }

        public bool sosMenor(Comparable c)
        {
            if (c.sosMenor(this.legajo))
            {
                return true;
            }
            return false;
        }

    }
}
