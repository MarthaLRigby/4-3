using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    class Program
    {
        //no longer using an enum
        const int Abby = 135;
        const int Bob = 175;
        const int Charlie = 55;
        const int Dawn =45;
        // moved these
        const int min = 100; 
        const int max = 300;
        static void Main(string[] args)
        {
            Console.WriteLine("Abby and Bob can ride together? {0}", CanRideTogether(Abby,Bob));
            Console.WriteLine("Charlie and Bob can ride together? {0}", CanRideTogether(Charlie, Bob));
            Console.WriteLine("Charlie and Dawn can ride together? {0}", CanRideTogether(Charlie, Dawn));
        }
        
        private static bool CanRideTogether(int first, int second) 
        {
            int total = first + second;
            if (total < max && total > min) 
                return true;
            else 
                return false;
            
        }
    }
}
