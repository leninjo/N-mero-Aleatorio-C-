using System;

namespace practicas.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int numero1 = 1;
            int numero2 = 2;
            double c = numero1 + numero2;
            Console.WriteLine("La suma es: " + c);

            Console.WriteLine("Ingresa un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número que ingresaste es: "+num);
            Console.WriteLine(typeof(num));*/
            
        Random rnd = new Random();
        int numero = rnd.Next(1,11);
        int intentos = 0;
        Console.WriteLine(numero);
        Console.WriteLine("Estoy pensando en un número entre 1 y 10.\n¿Puedes adivinar qué número es?.\n");
        while(intentos < 3){
        try{
            Console.WriteLine("Ingresa un número.\n--Intento " + (intentos+1) + "--");
            int res = Convert.ToInt32(Console.ReadLine());
            intentos = intentos + 1;
            if(res == numero){
            Console.WriteLine("Genial!\nAdivinaste mi número en el " + intentos + " intento.");
            break;
            }
            else if(res < numero && intentos < 3){
            Console.WriteLine("Ups, el número que ingresaste es menor a mi número.\n");
            }
            else if(res > numero && intentos < 3){
            Console.WriteLine("Ups, el número que ingresaste es mayor a mi número,\n");
            }
            if(intentos == 3){
            Console.WriteLine("Has perdido, el número que estaba pensando era " + numero + ".\n");
            }    
        }
        catch(FormatException){
            Console.WriteLine("Debes ingresar un numero entero.\n");
        }
        }    
        }
    }
}
