using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Significativa
{
    class Arbol
    {

        public Nodo raiz = null;
        public Nodo creaArbolDepartamento(Departamento[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                if (this.raiz == null)
                {
                    this.raiz = new Nodo(vec[i]);
                }
                else
                {
                    inserta(raiz, vec[i]);
                }
            }
            return (raiz);
        }
        public void inserta(Nodo nodo, Departamento d)
        {
            if (d.precio < nodo.dato.precio)
            {
                if (nodo.izq == null)
                {
                    Nodo aux = new Nodo(d);
                    nodo.izq = aux;
                }
                else
                {
                    inserta(nodo.izq, d);
                }
            }
            else
            {
                if (nodo.der == null)
                {
                    Nodo aux = new Nodo(d);
                    nodo.der = aux;
                }
                else
                {
                    inserta(nodo.der, d);
                }
            }
        }
        public void preOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                nodo.dato.verPrecio();
                preOrden(nodo.izq);
                preOrden(nodo.der);
            }
        }
        public void inOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                this.inOrden(nodo.izq);
                nodo.dato.verPrecio();
                this.inOrden(nodo.der);
            }
        }
        public void postOrden(Nodo arbol)
        {
            if (arbol != null)
            {
                this.postOrden(arbol.izq);
                this.postOrden(arbol.der);
                arbol.dato.verPrecio();
            }
        }
    }
}
