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
        }
        static void Main(string[] args)
        {
            int min = 100;
            int max = 300;
            bool possible = (((int)weight.Abby + (int)weight.Bob) < max && ((int) weight.Abby +(int) weight.Bob) > min) ? true : false;
            Console.WriteLine("{0} and {1} can ride together? {2}", weight.Abby, weight.Bob, possible);
            possible = (((int)weight.Charlie + (int)weight.Bob) < max && ((int)weight.Charlie + (int)weight.Bob) > min) ? true : false;
            Console.WriteLine("{0} and {1} can ride together? {2}", weight.Charlie, weight.Bob, possible);
            possible = (((int)weight.Charlie + (int)weight.Dawn) < max && ((int)weight.Charlie + (int)weight.Dawn) > min) ? true : false;
            Console.WriteLine("{0} and {1} can ride together? {2}", weight.Charlie, weight.Dawn, possible);
        }
    }
}
