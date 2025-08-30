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
            throw new NotImplementedException();
        }

       /** public Comparable Cuantos()
        {
            Numero cantPila = new Numero(this.p.CantidadElementos());
            Numero cantCola = new Numero(this.c.CantidadElementos());

            return (cantPila, cantCola);
        }
       **/
        public Comparable Maximo()
        {
            throw new NotImplementedException();
        }

        public Comparable Minimo()
        {
            throw new NotImplementedException();
        }
    }
}
