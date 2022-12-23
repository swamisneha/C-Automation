using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCS
{
    public class YoungerPerson
    {
        public static void Mainr(string[] args)
        {
            int smith = 25;
            int John = 45;
            int henry = 65;

            if (smith == John && John == henry)
            {
                Console.WriteLine("Smith, John, Henry are same age.");
            }

            if (smith > John)
            {
                if (John > henry)
                {
                    Console.WriteLine("John is youner");
                }
                else
                {
                    Console.WriteLine("henry is younger");
                }
    
                    Console.WriteLine("smith is younger");
            }
        }
    }
}
