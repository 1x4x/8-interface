using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Program1 : IProgram, IExtra
    {
        public void Start()
        {
            Console.WriteLine("Nu kör vi program 1");
        }

        public void Extra()
        {
            Console.WriteLine("Detta är en extra metod");
        }
    }
}
