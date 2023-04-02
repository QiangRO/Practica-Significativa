using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Significativa
{
    class Nodo
    {
        public Departamento dato;
        public Nodo izq;
        public Nodo der;
        public Nodo(Departamento d)
        {
            this.dato = d;
            this.izq = null;
            this.der = null;
        }
    }
}
