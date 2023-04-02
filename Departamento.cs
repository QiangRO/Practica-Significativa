using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Significativa
{
    class Departamento
    {
        //PROPIEDADES DEL DEPARTAMENTO
        public string codDepto = " ";
        public int nroDorm= 0;
        public double precio = 0.00;
        // CONSTRUCTOR POR DEFECTO
        public Departamento()
        {
            this.codDepto = "Sin codigo";
            this.nroDorm = 0;
            this.precio= 0.00;
        }
        //CONSTRUCTOR CON PARAMETROS
        public Departamento(string codDepto, int nroDorm, double precio) { 
        this.codDepto = codDepto;
        this.nroDorm = nroDorm;
        this.precio = precio;
        }
        //METODO PARA VER DATOS
        public void verDatos()
        {
            Console.WriteLine($"El codigo es : {this.codDepto}\n" +
                $"El numero es: {this.nroDorm}\n" +
                $"El precio: {this.precio}\n");
        }
        //METODO PARA VER PRECIO (USADO PARA LOS RECORRIDOS DEL ARBOL)
        public void verPrecio()
        {
            Console.WriteLine($"El precio: {this.precio}\t cod: {this.codDepto}");
        }
        //METODO PARA LEER DATOS POR TECLADO
        public void leerDatos()
        {
            Console.WriteLine("Codigo Dep:");
            this.codDepto=Console.ReadLine();
            Console.WriteLine("Numero Dorm:");
            this.nroDorm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Precio:");
            this.precio = Convert.ToDouble(Console.ReadLine());
            //VALIDACION DEL PRECIO EN UN RANGO DE 30000 A 65000
            while (precio < 30000.0 || precio > 65000.0)
            {
                Console.WriteLine("El precio debe estar entre 30.000 y 65.000 bs.");
                Console.WriteLine("Ingrese el precio nuevamente:");
                precio = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
