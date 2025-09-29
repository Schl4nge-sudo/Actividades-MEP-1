using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 2 : Implementar clase Numero y hacer que la misma implemente comparable

namespace Actividad_1_MP
{
    internal class Numero : Comparable
    {
        public int valor;
        public Numero(int v){
            this.valor = v;
            }
        public int getValor() { return valor; }

        public bool sosIgual(Comparable c)
        {
            if (((Numero)c).getValor() == this.valor) return true;
            else return false;
        }

        public bool sosMayor(Comparable c)
        {
            if (((Numero)c).getValor() > this.valor) return true;
            else return false;
        }

        public bool sosMenor(Comparable c)
        {
            if (((Numero)c).getValor() < this.valor) return true;
            else return false;
        }
        public override string ToString() => this.valor.ToString();
    }
}
