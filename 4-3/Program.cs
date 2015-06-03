using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    class Program
    {
        enum weight
        {
            Abby = 135,
            Bob = 175,
            Charlie = 55,
            Dawn =45
            // I wouldn't use an enum for the weights here - enums are meant to be for situations where you
            // have a set of values which are definitely unique - in this case, the weights are unique,
            // but they don't have to be. Using a set of constant ints would be better - see below.
        }
        const int Abby = 135;
        static void Main(string[] args)
        {
            int min = 100;
            int max = 300;
            // These are variables that get initialised every time you run your program - instead,
            // you should declare them as constants at the top of the file.
            bool possible = (((int)weight.Abby + (int)weight.Bob) < max && ((int) weight.Abby +(int) weight.Bob) > min) ? true : false;
            Console.WriteLine("{0} and {1} can ride together? {2}", weight.Abby, weight.Bob, possible);
            possible = (((int)weight.Charlie + (int)weight.Bob) < max && ((int)weight.Charlie + (int)weight.Bob) > min) ? true : false;
            Console.WriteLine("{0} and {1} can ride together? {2}", weight.Charlie, weight.Bob, possible);
            possible = (((int)weight.Charlie + (int)weight.Dawn) < max && ((int)weight.Charlie + (int)weight.Dawn) > min) ? true : false;
            Console.WriteLine("{0} and {1} can ride together? {2}", weight.Charlie, weight.Dawn, possible);
            // You have a lot of code duplication here. It might be better if you used a small method to work out
            // whether 2 passengers can ride together. I've put a prototype for you below - try using this to 
            // commonise your code.
        }
        
        private static bool CanRideTogether(int first, int second) 
        {
            // Put some code here!
            return true;
        }
    }
}
