using ConsoleApp3.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            var estruc = new clsEstructura().cargaDatosXLS();

            MATRIZ leer = new MATRIZ();
            leer.leermatriz();
            leer.rellenarmatrizcero();

            



            Console.ReadLine();
              
           
        }
    }
}
