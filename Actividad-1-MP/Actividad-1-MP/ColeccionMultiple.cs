using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 8 - Crear clase coleccion multiple


namespace Actividad_1_MP
{
    internal class ColeccionMultiple : Coleccionable
    {
        Pila p;
        Cola c;

        public ColeccionMultiple(Pila p, Cola c) {
        
        this.p = p;
        this.c = c;
        
        }

        public void Agregar(Comparable c)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(Comparable c)
        {
            if (this.c.Contiene(c) || this.p.Contiene(c))
            {
                return true;
            }
            return false;
        }

        public int Cuantos()
        {
            return this.p.CantidadElementos() + this.c.CantidadElementos();
        }
       
        public Comparable Maximo()
        {
            if (this.p.Maximo().sosMayor(this.c.Maximo()))
            {
                return this.p.Maximo();
            }
            if (this.c.Maximo().sosMayor(this.p.Maximo()))
            {
                return this.c.Maximo();
            }
            else { throw new NotImplementedException();  } 
        }

        public Comparable Minimo()
        {
            if (this.p.Minimo().sosMenor(this.c.Minimo()))
            {
                return this.p.Minimo();
            }
            if (this.c.Minimo().sosMenor(this.p.Minimo()))
            {
                return this.c.Minimo();
            }
            else { throw new NotImplementedException(); }
        }
    }
}
