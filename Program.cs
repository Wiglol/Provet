using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_U._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: "); 
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (Num == 0)
            {
              Console.WriteLine("The number is zero");
    
            }
            else if( Num < 0)
            {
                Console.WriteLine("The number is negative"); 
            }
            else
            {
                Console.WriteLine("Invalid Input"); 
            }
            
            
            
            
                
            




            Console.ReadLine();
        }
    }
}
