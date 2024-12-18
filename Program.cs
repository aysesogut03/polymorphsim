using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hayvan hayvan = new hayvan("hayvan");
            hayvan.konus();

            kedi kedi = new kedi("minnos");
            kedi.konus();

            kopek kopek = new kopek("karabaş");
            kopek.konus();

            Console.ReadLine();
        }
    }
}
