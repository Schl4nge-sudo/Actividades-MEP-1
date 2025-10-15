using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_MP
{
    //Ejercicio 12 - Implementar alumno como subclase de persona
    internal class Alumno : Persona, Comparable
    {
        protected Numero legajo;
        protected Numero promedio;
        protected Strategy estrategia;

        public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
        {
           this.legajo = l;
           this.promedio = p;
        }

        public Numero getLegajo() {  return this.legajo; }
        public Numero getPromedio() { return this.promedio; }

        //Metodo para elegir el tipo de estrategia (por nombre, dni, legajo)
        public void setEstrategia(Strategy nuevaEstrategia) { this.estrategia = nuevaEstrategia; }
        public override bool sosIgual(Comparable c) { return estrategia.sosIgual(this, (Alumno)c); }

        public override bool sosMayor(Comparable c) { return estrategia.sosIgual(this, (Alumno)c); }

        public override bool sosMenor(Comparable c) { return estrategia.sosIgual(this, (Alumno)c); }

        

    }
}
