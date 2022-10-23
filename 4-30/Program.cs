using System;

namespace _4_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många X I en grupp?");
            int användarensvarX = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O I en grupp?");
            int användarensvarY = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O mönster I en rad?");
            int Orad =int.Parse (Console.ReadLine());

            Console.WriteLine("Hur många rad vill du ha?");
            int rad = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i <rad; i++)
            {
                for (int X = 0; X < användarensvarX; X++)
                {
                    Console.Write("X");
                }
            
            for (int j = 0; j < Orad; j++)
                {
                Console.Write("-");
            

            
                for (int O = 0; O < användarensvarY; O++)
                        {
                            Console.Write("O");
                         
                        }
                Console.Write("-");

                for (int X = 0; X < användarensvarX; X++)
                {
                    Console.Write("X");
                }


               }
                Console.WriteLine();

            }

        }
    }
}
