using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
          //Declarar una variable int para opciones

          int opciones;

          do
          {
            console.writeline("\n\nMenu:");
            console.writeline("1.Programa que muestre los numeros de n al 1 de manera descendentes");
            console.writeline("2.Programa que muestre los numeros de n al 1 con while");
            console.writeline("3.Programa que muestre el numero minimo de una lista");
            console.writeline("4.Salir");
            console.writeline("Seleccione una opcion (1-4): ");

          if (int.Tryparse(console.ReadLine(), out opciones))
          {
            switch (opciones)
            {
                case 1:
                   console.write("\nIngrese un numero (n): ");
              int n=  Convert.ToInt32(console.ReadLine());

              numerosDescendente(numero);

                    break;
                 case 2:
                    maximoLista();
                    break;
                case 3:

                    console.writeline("\nIngrese la nota 1 ")
                    decimal nota1=Convert.ToDecimal(console.ReadLine());

                    console.writeline("\nIngrese la nota 2 ")
                    decimal nota2=Convert.ToDecimal(console.ReadLine());

                    console.writeline("\nIngrese la nota 3 ")
                    decimal nota3=Convert.ToDecimal(console.ReadLine());

                    promedio(nota1,nota2,nota3);

                    break;
                 case 4:

                    break;
                 default:
                  console.writeline("Opcion no valida. por favor, seleccione una opcion valida (1-4).");
                  break;
            }
            
          }
          else{
              console.writeline("\nEntrada no valida. Debe ingresar un numero (1-4).");
          }

          } while (opciones !=4);

        }// fin del main


        static void numerosDescendente (int n){

         if (n >= 1)
        {
              for (int i =n; i >= 1; i--)
             {
               console.writeline($"Numero > {i}");

             }
        }

         else{
            console.writeline("Ingresar un numero mayor a 1 ");
             }
        
        }//fin de funcion


        static void maximoLista(){
          
           static void minimoLista(){
        
        List<int> numeros = new List<int> {24,15,45,35,14,10 };

            int maximo = numeros[0]; //Inicializar con valor del indice 0

            foreach ( int numero1 in numeros)
            {
                     
                if( numero1 < maximo)
                {
                  maximo = numero1; // Actualizar el valor maximo
                }
            }

            console.writeline ("El numero mas grande en la lista es > " + maximo);

        }//fin de funcion maximo


        static void promedio(decimal n1, decimal n2, decimal3){

            decimal promedioGlobal= (n1+n2+n3)/3

            decimal promedioLimit=Math.Round(promedioGlobal,2);

            if (promedioLimit >=6)
            {
                console.Foregroundcolor=ConsoleColor.Green;
                console.writeline($"\nSu promedio es {promedioLimit} esta Aprobado");

            }
            else
            {
              console.Foregroundcolor=ConsoleColor.Red;
                console.writeline($"\nSu promedio es {promedioLimit} esta Reprobado");
            }

        }
    }
}