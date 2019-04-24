using System;
using System.Collections;

namespace pilasycolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PILAS Y COLAS!");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            //PILA
            Console.WriteLine("PILAS...");
           
            Console.WriteLine("PILAS numeros");
            int numeros;

            Stack numero = new Stack();

            numero.Push(1);
            numero.Push(2);
            numero.Push(3);
            numero.Push(4);
            numero.Push(5);
            numero.Push(6);
            numero.Push(7);
            numero.Push(8);
            numero.Push(9);
            numero.Push(10);

            for (int i = 0; i < 10; i++)
            {
                numeros = (int)numero.Pop();
                Console.WriteLine(numeros);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("PILA string");
            string palabras;
            Stack palabra = new Stack();

            palabra.Push("juan");
            palabra.Push("paco");
            palabra.Push("pedro"); 
            palabra.Push("de");
            palabra.Push("la");
            palabra.Push("mar");
            
            palabra.Push("es");

            palabra.Push("mi");
            palabra.Push("nombre");
            palabra.Push("asi");

            for (int i = 0; i < 10; i++)
            {
                palabras = (string)palabra.Pop();
                Console.WriteLine(palabras);
            }

            Console.WriteLine("");
            Console.WriteLine("");

            //COLA
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("COLAS...");
           
            Console.WriteLine("COLA numeros");
            int numeroscola;

            Queue num = new Queue();

            num.Enqueue(1);
            num.Enqueue(2);
            num.Enqueue(3);
            num.Enqueue(4);
            num.Enqueue(5);
            num.Enqueue(6);
            num.Enqueue(7);
            num.Enqueue(8);
            num.Enqueue(9);
            num.Enqueue(10);

            for (int i = 0; i < 10; i++)
            {
                numeroscola = (int) num.Dequeue();
                Console.WriteLine(numeroscola);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("COLA string");
            string plabrascola;

            Queue palabracola = new Queue();

            palabracola.Enqueue("juan");
            palabracola.Enqueue("paco");
            palabracola.Enqueue("pedro");
            palabracola.Enqueue("de");
            palabracola.Enqueue("la");
            palabracola.Enqueue("mar");

            palabracola.Enqueue("es");

            palabracola.Enqueue("mi");
            palabracola.Enqueue("nombre");
            palabracola.Enqueue("asi");

            for (int i = 0; i < 10; i++)
            {
                plabrascola = (string)palabracola.Dequeue();
                Console.WriteLine(plabrascola);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
