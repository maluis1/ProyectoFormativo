﻿using System;

namespace ProyectoFormativo
{
    class Program
    {
        static void Main(string[] args)
        {
            proyectoF proyecto1 = new proyectoF();
            proyectoF proyecto2 = new proyectoF( "elite",18,21);

            //proyecto1.IngresarDatos();
            //proyecto1.ImprimirDatos();
            proyecto2.ModificarDatos();
            proyecto2.ImprimirDatos();
            Console.ReadLine();
        }
    }
}
