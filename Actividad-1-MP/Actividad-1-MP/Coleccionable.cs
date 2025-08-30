using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 3 - Implementar interfaz coleccionable

namespace Actividad_1_MP
{
    public interface Coleccionable
    {
        public Comparable Cuantos();
        public Comparable Minimo();
        public Comparable Maximo();
        public void Agregar(Comparable c);
        public bool Contiene (Comparable c);

    }
}
