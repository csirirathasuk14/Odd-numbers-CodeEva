using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter a number.");
            int number = int.Parse(Console.ReadLine());
            for (int i=0; i<1; i++)
            {
                if(number % 3==0)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                
            for (int x = 0; x < 1; i++)
                {
                    if(number % 3 ==1 || number % 3==2)
                    {
                        Console.WriteLine("You lose, enter another number");
                        number = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                }
            
            }
            


                           

        }
    }
}
