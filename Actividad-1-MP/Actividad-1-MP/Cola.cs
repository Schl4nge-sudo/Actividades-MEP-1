using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_MP
{
    public class Cola : Coleccionable
    {
        private List<int> datos = new List<int>();

        public void Encolar(int elem)
        {
            this.datos.Add(elem);
        }

        public int Desencolar()
        {
            if (this.datos.Count == 0)
                throw new InvalidOperationException("La cola está vacía.");

            int temp = this.datos[0];
            this.datos.RemoveAt(0);
            return temp;
        }

        public int Tope()
        {
            if (this.datos.Count == 0)
                throw new InvalidOperationException("La cola está vacía.");

            return this.datos[0];
        }

        public bool EsVacia()
        {
            return this.datos.Count == 0;
        }

        public int CantidadElementos()
        {
            return this.datos.Count;
        }

        public Comparable Cuantos()
        {
            return new Numero(this.datos.Count());
        }

        public Comparable Minimo()
        {
            if (this.datos.Count == 0)
                throw new InvalidOperationException("La pila está vacía.");

            Comparable masChico = new Numero(this.datos[0]);

            for (int i = 1; i < this.datos.Count; i++)
            {
                Comparable actual = new Numero(this.datos[i]);

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

            Comparable masGrande = new Numero(this.datos[0]);

            for (int i = 1; i < this.datos.Count; i++)
            {
                Comparable actual = new Numero(this.datos[i]);

                if (actual.sosMayor(masGrande))
                {
                    masGrande = actual;
                }
            }

            return masGrande;
        }

        public void Agregar(Comparable c)
        {
            Numero n = (Numero)c;
            this.Encolar(n.getValor());
        }

        public bool Contiene(Comparable c)
        {
            if (this.datos.Count == 0)
                throw new InvalidOperationException("La pila está vacía.");

            for (int i = 1; i < this.datos.Count; i++)
            {
                Comparable actual = new Numero(this.datos[i]);

                if (actual.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
