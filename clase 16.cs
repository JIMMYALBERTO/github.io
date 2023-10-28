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
                  numerosDescente();
                    break;
                 case 2:
                    numeroswhile();
                    break;
                case 3:
                    minimoLista();
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


       static void numerosDescente()
       {
         console.write("\nIngrese un numero (n): ");
              int n=  Convert.ToInt32(console.ReadLine());

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
       }//fin de numerosDescendentes


       static void numeroswhile(){

        int contador = 1;

                        while (contador <=5)
                        {
                            console.writeline($"Numero >>{contador}");
                            contador++;
                        }
       }//fin de numeroswhile


       static void minimoLista(){
        
        List<int> numeros = new List<int> {24,15,45,35,14,10 };

            int minimo = numeros[0]; //Inicializar con valor del indice 0

            foreach ( int numero1 in numeros)
            {
                     
                if( numero1 < minimo)
                {
                  minimo = numero1; // Actualizar el valor minimo
                }
            }

            console.writeline ("El numero mas pequeño en la lista es > " + minimo);
       //fin de minimoLista
    }
}