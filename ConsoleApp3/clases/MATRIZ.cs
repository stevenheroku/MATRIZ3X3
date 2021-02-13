using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.clases
{
    class MATRIZ
    {

        int rosw = 0;
        private int[,] matrix = new int[3,3];
        int rows = 0;
        int col = 0;

        public void leermatriz()    
        {
          //LEO LA MATRIZ QUE TENGO EN EXCEL PARAA IMPRIMIRLA
            
            var estruc = new clsEstructura().cargaDatosXLS();


            Console.WriteLine("Leer Matriz del Archivo de Excel\n");
            foreach (var excel in estruc)
            {
                matrix[rows, 0] = excel.matric1;
                matrix[rows, 1] = excel.matric2;
                matrix[rows, 2] = excel.matric3;
                Console.WriteLine(" \t" + matrix[rows, 0] + "\t" + matrix[rows, 1] + "\t" + matrix[rows, 2] + "\n");

                rows++;
            }    


        }


        public void rellenarmatrizcero()
        {
            
 
            Console.WriteLine("\nCambiar Filas y columnas por 0 \n");
            Console.ReadLine();

            for (int a = 0; a < 3;a++)
            {
                for(int j = 0; j < 3;j++)
                {
                    //comparo que fila y columna tiene el 0
                    if(matrix[a,j] == 0)
                    {
                         rosw = a;
                       

                    }
                }
                
            }


            //
            for (int i = 0; i < 2; i++)// cambiar filas y columnas por 0
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = matrix[i, j] * matrix[i + 1, j];
                    matrix[i + 1, j] = matrix[i, j] * matrix[i + 1, j];
                }
            }



            matrix[rosw, 0] = 0;
            matrix[rosw, 1] = 0;
            matrix[rosw, 2] = 0;

            for (int fila = 0; fila < 3; fila++)
            {
                matrix[rosw, col] = 0;
                Console.WriteLine(matrix[fila, 0] + "\t" + matrix[fila, 1] + "\t" + matrix[fila, 2]);
            }

        }


    }
}
