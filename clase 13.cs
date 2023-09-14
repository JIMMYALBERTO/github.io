 using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //for    //foreach
            
          /*  //casi simple de for

            for (int i = 0; i < 10; i++)
            {
                
                console.WriteLine($"El numero (i)");

            }//fin de for*/


            /*console.WriteLine("\nIngrese un numero para elaborar su tabla de multiplicar ");
            int numero=Convert.Toint32(console.ReadLine());

            for (int i = 1; i <=10; i++)
            {
                
              int multiplicacion = numero * i;

              console.WriteLine($"{numero} x {i} x {multiplicacion}");

            }*/

            //foreach

            //Declarar una lista

            List<int> numeros = new List<int> {24,10,8,35,14,26};

            int minimo = numeros[0]; // inicializar con valor del indice 0


            foreach (int numero1 in numeros)
            {
              

               if (numero1 < minimo)
               {
                
                 minimo = numero1; //actualizar el valor minimo

               }


            }

            console.WriteLine ("El numero mas pequeño en la lista es > " + minimo);

            //VALORES POR INTERRACCIONES
            //1 NUMERO VALDRIA 24 MINIMO 24 COMPARAMOS MINIMO =24
            //2 NUMERO = 10 MINIMO 10 COMPARAMOS MINIMO = 10
            //3 NUMERO = 8  MINIMO 8 COMPARAMOS MINIMO = 8
            //4 NUMERO = 35 MINIMO 8 COMPARAMOS MINIMO = 8
            //5 NUMERO = 14 MINIMO 8 COMPARAMOS MINIMO = 8
            //6 NUMERO = 26 MINIMO 8 COMPARAMOS MINIMO = 8

            console.readkey();

        }
    }
}