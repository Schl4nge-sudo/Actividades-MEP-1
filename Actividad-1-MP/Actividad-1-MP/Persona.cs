using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_MP
{
    // Ejercicio 12 - Implementar clase persona
    internal class Persona : Comparable
    {
        String nombre;
        Numero dni;

        public Persona(string n, Numero d) {
                  
            this.nombre = n;
            this.dni = d;

        }
        public String Nombre { get { return nombre; } }
        public int Dni { get { return this.dni.getValor(); } }

        public virtual bool sosIgual(Comparable c)
        {
            if (c.sosIgual(this.dni))
            {
                return true;
            }
            return false;
        }

        public virtual bool sosMayor(Comparable c)
        {
            if (c.sosMayor(this.dni))
            {
                return true;
            }
            return false;
        }

        public virtual bool sosMenor(Comparable c)
        {
            if (c.sosMenor(this.dni))
            {
                return true;
            }
            return false;
        }

        public override string ToString() => string.Format("[Persona: Nombre={0}, Dni={1}]", nombre, dni);

    }
}
