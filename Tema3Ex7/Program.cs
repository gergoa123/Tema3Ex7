using System;

namespace Tema3Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar ");
            int numar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar ");
            int numar2 = int.Parse(Console.ReadLine());

            int a = 0;
            int auxMare = 0;
            int auxMic = 0;
            int divizor = 0;

            if (numar1 > numar2)
            {
                auxMare = numar1;
                auxMic = numar2;
            }
            else 
            {
                auxMare = numar2;
                auxMic = numar1;           
            }


           
            
            a = auxMic;
            while (0 != a && divizor == 0)
            {
                    if (auxMare % a == 0 & auxMic % a == 0)
                    {
                     divizor = a;
                     
                    }
                     a--;
                

            }
                Console.WriteLine("Cel mai mare divizor este " + divizor);




        }
    }
}
