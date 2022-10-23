using System;

namespace CApp
{
    class Program
    {
        static void Main(string[] args)
        {
            clsPila2 P = new clsPila2();
            P.Add(0, 3);
            P.Add(0, 4);
            P.Add(0, 7);
            System.Console.WriteLine(P.Imprimir());
            P.Add(1, 9);
            P.Add(1, 10);
            System.Console.WriteLine(P.Imprimir());

            Console.ReadKey();
        }
    }
}
