using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.U1_W1_D4.OOP_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authentication auth = new Authentication();
            auth.MenuOperazioni();
            Console.ReadLine();
        }

    }

}
