using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_MP
{
    public interface Strategy
    {
        public bool sosIgual(Comparable c1, Comparable c2);
        public bool sosMenor(Comparable c1, Comparable c2);
        public bool sosMayor(Comparable c1, Comparable c2);

    }
}
