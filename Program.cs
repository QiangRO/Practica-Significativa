namespace Practica_Significativa
{
    internal class Program
    {
        class NodoLista
        {
            //COMPONENTES
            public Departamento dato;
            public NodoLista sig;
            public void verNodo()
            {
                Console.Write(dato + " ");
            }
        }
        class Lista
        {
            public NodoLista TOPE;
            public void verLista()
            {
                NodoLista aux = this.TOPE;
                if (aux == null)
                {
                    Console.WriteLine("Lista vacia");
                }
                else
                {
                    while (aux != null)
                    {
                        aux.dato.verDatos();
                        aux = aux.sig;
                    }
                }
            }
            public void agregarElementoInicio(NodoLista nodo)
            {
                if (this.TOPE == null)
                {
                    this.TOPE = nodo;
                }
                else
                {
                    nodo.sig = this.TOPE;
                    this.TOPE = nodo;
                }
            }
            public void agregarElementoFin(NodoLista nodo)
            {
                if (this.TOPE == null)
                {
                    this.TOPE = nodo;
                }
                else
                {
                    NodoLista aux = this.TOPE;
                    while (aux.sig != null)
                    {
                        aux = aux.sig;
                    }
                    aux.sig = nodo;
                    nodo.sig = null;
                }
            }
            public void buscar(NodoLista nodo, Departamento dato)
            {
                bool encontrado = false;
                NodoLista aux = this.TOPE;
                if (aux == null)
                {
                    Console.WriteLine("Lista vacia");
                }
                else
                {
                    while (aux != null)
                    {
                        if (dato == aux.dato)
                        {
                            encontrado = true;
                        }
                        aux = aux.sig;
                    }
                }
                if (encontrado)
                {
                    Console.WriteLine(dato + "esta en la lista");
                }
            }
            //METODO QUE RETORNO ELEMENTOS DE LA LISTA, PARA GUARDARLOS EN UN VECTOR TIPO DEP
            public int CantidadElementos()
            {
                int cantidad = 0;
                NodoLista aux = this.TOPE;
                while (aux != null)
                {
                    cantidad++;
                    aux = aux.sig;
                }
                return cantidad;
            }
        }
        /*
            public void agregarCriterio (NodoLista nodo)
            {
                bool encontrado = false;
                NodoLista aux = this.TOPE;
                if (aux == null)
                {
                    Console.WriteLine("Lista vacia");
                }
                else
                {
                    string nombre = Console.ReadLine();
                    while (aux != null)
                    {
                        if (nombre == aux.dato)
                        {
                            encontrado = true;
                            nodo.sig = aux.sig;
                            aux.sig = nodo;
                        }
                    }
                }
            }
            */
        //MAIN
        
        static void Main(string[] args)
        {
            //OBJETOS DEPARTAMENTO Y LEYENDO DATOS POR TECLADO
            Lista lista = new Lista();
            Console.WriteLine("Agregando elementos a la lista");
            Departamento dep1 = new Departamento();
            dep1.leerDatos();
            Departamento dep2 = new Departamento();
            dep2.leerDatos();
            Departamento dep3 = new Departamento();
            dep3.leerDatos();
            Departamento dep4 = new Departamento();
            dep4.leerDatos();
            //OBJETOS DEPARTAMENTO PARA EL VECTOR QUE SERA PARAMETRO DEL METODO "creaArbolDepartamento"
            Departamento depArbol = new Departamento("dep1", 10, 45000);
            Departamento depArbol2 = new Departamento("dep2", 11, 60000);
            Departamento depArbol3 = new Departamento("dep3", 12, 64000);
            Departamento depArbol4 = new Departamento("dep4", 13, 37000);
            Departamento depArbol5 = new Departamento("dep5", 14, 43000);

            //CREANDO NODOS LISTA Y PASANDOLOS COMO PARAMETROS AL METODO "agregarElementoInicio"
            NodoLista nodoLista = new NodoLista();
            nodoLista.dato = dep1;
            lista.agregarElementoInicio(nodoLista);
            
            NodoLista nodoLista2 = new NodoLista();
            nodoLista2.dato = dep2;
            lista.agregarElementoInicio(nodoLista2);
            
            NodoLista nodoLista3 = new NodoLista();
            nodoLista3.dato = dep3;
            lista.agregarElementoInicio(nodoLista3);

            NodoLista nodoLista4 = new NodoLista();
            nodoLista4.dato = dep4;
            lista.agregarElementoInicio(nodoLista4);

            //IMPRIMIENDO DATOS DE LA LISTA
            Console.WriteLine(" \n***** Objetos en la lista *****\n");
            lista.verLista();

            /*4.	Copiar los elementos de la lista en un vector y ORDENAR por el método de BURBUJA,
             el criterio para ordenar será el precio de los departamentos que oscilan entre 30 000 y 65 000.*/
            
            //VECTOR QUE ALMACENA LOS ELEMENTOS DE LA LISTA
            Departamento[] vectorDepartamento = new Departamento[lista.CantidadElementos()];
            NodoLista aux = lista.TOPE;
            int n = 0;
            while (aux != null)
            {
                vectorDepartamento[n] = aux.dato;
                n++;
                aux = aux.sig;
            }
            //IMPRIMIMOS LOS ELEMENTOS DEL VECTOR
            Console.WriteLine(" \n***** Elementos del vector de departamentos *****\n");
            for (int j = 0; j < vectorDepartamento.Length; j++)
            {
                vectorDepartamento[j].verDatos();
            }
            //METODO DE ORDENAMIENTO BURBUJA DE MENOR A MAYOR
            int tamVec = vectorDepartamento.Length;
            for (int i = 0; i < tamVec - 1; i++)
            {
                for (int j = 0; j < tamVec - i - 1; j++)
                {
                    if (vectorDepartamento[j].precio > vectorDepartamento[j + 1].precio)
                    {
                        Departamento aux2 = vectorDepartamento[j];
                        vectorDepartamento[j] = vectorDepartamento[j + 1];
                        vectorDepartamento[j + 1] = aux2;
                    }
                }
            }
            //IMPRIMIENDO LOS ELEMENTOS YA ORDENADOS DEL VECTOR
            Console.WriteLine(" \n***** Departamentos de menor a mayor - BUBBLE SORT *****\n");
            foreach (Departamento depto in vectorDepartamento)
            {
                depto.verPrecio();
            }
            //5.	Crear un árbol donde el Nodo raíz contiene un Departamento con precio de 45 000.
            //DATOS DEL PRECIO DE DEPARTAMENTOS
            /*
            depArbol = ("depArbol", 10, 45000);
            depArbol2 = ("depArbol2", 11, 60000);
            depArbol3 = ("depArbol3", 12, 64000);
            depArbol4 = ("depArbol4", 13, 37000);
            depArbol5 = ("depArbol5", 14, 43000);*/
            Departamento[] vectorDepArbol = new Departamento[] { depArbol, depArbol2, depArbol3, depArbol4, depArbol5};

            //OBJETOS ARBOL NODO Y LOS RECORRIDOS
            Arbol arbolDep = new Arbol();
            Nodo nodoRaizDep;
            nodoRaizDep = arbolDep.creaArbolDepartamento(vectorDepArbol);
            Console.WriteLine("\n\n************ RECORRIDOS ARBOL DEPARTAMENTOS ************");
            Console.WriteLine("**********RECORRIDO PREORDEN: ");
            arbolDep.preOrden(nodoRaizDep);
            Console.WriteLine("\n**********RECORRIDO INORDEN: ");
            arbolDep.inOrden(nodoRaizDep);
            Console.WriteLine("\n**********RECORRIDO POSTORDEN: ");
            arbolDep.postOrden(nodoRaizDep);
            Console.ReadKey();
        }
    }
}