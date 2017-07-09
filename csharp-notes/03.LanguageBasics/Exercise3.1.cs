using System;

namespace _1.Concepts
{
    class Exercise1_1
    {
        public static void Solution()
        {
            //Q. Give an example, from this file, of one of the following:

            // GRAMMAR 1 :
            // literal
            // operators
            // identifiers
            // keywords 
            
            // GRAMMAR 2:
            // expressions
            // statements
            //   -- defintions


            // SEMANTICS :
            // variables
            // constants
            // methods
            // namespaces
            // types
            // values / objects


            string empty;

            string name = "Michael";

            const int UkPopulation = 65000000;
            const double Emmigration = 2E6;
            const double Immigration = 2.5E6;

            int people = 0xB;


            decimal money = 100.0M;

            double net = UkPopulation + (Emmigration - Immigration);

            System.Console.WriteLine($"Next year's net population is {net}");
        }
    }
}