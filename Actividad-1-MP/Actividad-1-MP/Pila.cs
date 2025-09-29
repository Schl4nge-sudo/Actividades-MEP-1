using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 4 - Implementar clases pila y cola, implementar en las mismas la interfaz Coleccionable
namespace Actividad_1_MP
{
    internal class Pila : Coleccionable
    {
        private List<Comparable> datos = new List<Comparable>();

        public void Apilar(Comparable elem)
        {
            this.datos.Add(elem);
        }

        public int Desapilar()
        {
            if (this.Cuantos() == 0)
                throw new InvalidOperationException("La pila está vacía.");

            int temp = this.Cuantos() - 1;
            this.datos.RemoveAt(this.Cuantos() - 1);
            return temp;
        }

        public bool EsVacia()
        {
            return this.Cuantos() == 0;
        }

        public int CantidadElementos()
        {
            return this.datos.Count;
        }

        public Comparable Tope()
        {
            if (this.Cuantos() == 0)
                throw new InvalidOperationException("La pila está vacía.");

            return this.datos[this.Cuantos() - 1];
        }

        public int Cuantos()
        {
            return this.datos.Count();
        }

        public Comparable Minimo()
        {

            if (this.datos.Count == 0)
                throw new InvalidOperationException("La pila está vacía.");

            Comparable masChico = this.datos[0];

            for (int i = 1; i < this.datos.Count; i++)
            {
                Comparable actual = this.datos[i];

                if (actual.sosMenor(masChico))
                {
                    masChico = actual;
                }
            }

            return masChico;
        }

        public Comparable Maximo()
        {

            if (this.datos.Count == 0)
                throw new InvalidOperationException("La pila está vacía.");

            Comparable masGrande = this.datos[0];

            for (int i = 1; i < this.datos.Count; i++)
            {
                Comparable actual = this.datos[i];

                if (actual.sosMayor(masGrande))
                {
                    masGrande = actual;
                }
            }

            return masGrande;
        }

        public void Agregar(Comparable c)
        {
            this.Apilar(c);
        }

        public bool Contiene(Comparable c)
        {
            if (this.datos.Count == 0)
                throw new InvalidOperationException("La pila está vacía.");

            for (int i = 1; i < this.Cuantos(); i++)
            {
                Comparable actual = this.datos[i];

                if (actual.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
