using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1star_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  for (int i = 1; i <= 10; i++)
              {
                  for (int j = 1; j <= 10; j++)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }
              Console.ReadLine();*/

            /*int count = 0;
            for (int i = 1; i <= 10; i++) 
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                count++;
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /* int count = 0;
             for (int i = 1; i <= 10; i++) 
             {
                 for(int j = i; j <= 10; j++)
                 {
                     Console.Write("*");
                 }
                 count++;
                 Console.WriteLine();
             }
             Console.ReadLine();*/

            /* for (int i = 0; i <= 10; i++) 
             {
                 for(int j = 0; j<= i; j++)
                 {
                     Console.Write("*");
                 }  
                 Console.WriteLine(); 
             }

             for(int i = 1;i <= 10; i++)
             {
                 for (int j = i; j <= 10; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();*/

            /*  for (int i = 1; i <= 10; i++)
              {
                  for (int j = 1; j <= i; j++)
                  {
                      Console.Write(j);
                  }
                  Console.WriteLine();
              }
              Console.ReadLine(); */

            /*for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            /* int count = 0;

             for (int i = 1; i <= 4; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     count++;
                     Console.Write(count);
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();*/

            /* for (int i = 1; i <= 10; i++)
             {
                 for (int j = i; j <= 9; j++)
                 {
                     Console.Write(" ");
                 }
                 for (int k = 1;k <= i; k++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/

            /*for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= 10; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

//            for (int i = 1;i <= 10; i++)
//            {
//                for (int j = i; j <= 9; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 1; k <= i; k++)
//                {
//                    Console.Write("*");       
//                }
//                Console.WriteLine();
//            }

//            for (int i = 1; i <= 9; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = i; k <= 9; k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }


//            for (int i = 1; i <= 10; i++)
//            {
//                for (int j = 2;  j <= i;  j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = i; k <= 10; k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            for (int i = 2; i <= 10; i++)
//            {
//                for (int j = i; j <= 9; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 1; k <= i; k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }

           // Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <= 9; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 2; k <= i ; k++)
                {
                    Console.Write("*");
                }
                for (int l = 1; l <= i ; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= 9; k++)
                {
                    Console.Write("*");
                }
                for (int l = i; l <= 8; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine() ;
        }
   }
}
