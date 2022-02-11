using System;

namespace Esercizio1Stringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizi Stringhe 3");
            string parola = "";
            int contaparole = 0;
            while (parola != "fine")
            {
                Console.WriteLine("inserisci una parola");
                parola = Console.ReadLine();
                char prima = parola[0];
                char ultima = parola[lunghezza - 1];
                int lunghezza = parola.Length;
                if (prima == ultima)
                {
                    contaparole++;
                }
                Console.WriteLine("Ci sono che iniziano" + parola + "e finiscono " + ultima);
            }
        }
    }
}
