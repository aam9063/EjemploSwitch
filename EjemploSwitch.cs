/* 
Se pide una letra, si la letra es 'd' o 'D' , se escribirá en la pantalla DESCUENTO, si la letra
es 'i' o 'I' , se escribirá IVA en la pantalla, si la letra es 'p' o 'P' , se escribirá
PORCENTAJE en otro caso se escribirá DATO ERRÓNEO.
Realiza el ejercicio con switch y usa case continuos para la minúscula y mayúscula de la
misma letra. 
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Por favor, ingresa una letra: ");
        char letra = Console.ReadKey().KeyChar;

        switch (char.ToUpper(letra))
        {
            case 'D':
                Console.WriteLine("\nDESCUENTO");
                break;
            case 'I':
                Console.WriteLine("\nIVA");
                break;
            case 'P':
                Console.WriteLine("\nPORCENTAJE");
                break;
            default:
                Console.WriteLine("\nDATO ERRÓNEO");
                break;
        }
    }
}
