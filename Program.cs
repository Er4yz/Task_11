using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Transport transport = new Transport("1", 150654);

            transport.Move(325);
            transport.DisplayInfo();
        }
    }
}
