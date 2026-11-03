using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePart2
{
    internal class MyProgram : IFirst, ISecond
    {
        void IFirst.Run()
        {
            Console.WriteLine("Void Run-metoden körs");
        }

        int ISecond.Run()
        {
            Console.WriteLine("Int Run-metoden körs");
            return 7;
        }
    }
}
