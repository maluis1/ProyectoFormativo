using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFormativo
{
    class proyectoF
    {
       
        #region Propiedades
        public string Nombre { get; set; }
        public int EdadMin { get; set; }
        public int EdadMax { get; set; }
        #endregion

        #region Constructores
        public proyectoF(string nombre,int edadmin,int edadmax)
        {
            Nombre = nombre;
            EdadMax = edadmax;
            EdadMin = edadmin;
        }
        public proyectoF()
        {

        }
        #endregion
        #region Metodos
        public void IngresarDatos()
        {
            Console.WriteLine("Ingrese el nombre de la categoria: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad minima de la categoria:");
            EdadMin =  int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad maxima de la categoria:");
            EdadMax = int.Parse(Console.ReadLine());
        }
        public void ImprimirDatos()
        {
            Console.WriteLine($" Nombre: {Nombre}");
            Console.WriteLine($" Edad Minima: {EdadMin}");
            Console.WriteLine($" Edad Maxima: {EdadMax}");
        }
        public void ModificarDatos()
        {
            Console.WriteLine("Digite el rango de edad a modificar");
            EdadMax = int.Parse(Console.ReadLine());
        }
        #endregion
    }
}
