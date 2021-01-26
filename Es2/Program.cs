using System;
using LibreriaEsArray;
namespace Es2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisori di: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Gestione.Divisori(n);
        }
    }
}
