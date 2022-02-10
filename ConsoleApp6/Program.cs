using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Programm
    {
        static void Main()
        {
            Queue yt = new(); 

            yt.Enqueue(6);
            yt.Enqueue(12);
            yt.Enqueue(24);
            yt.Enqueue(48);

            yt.Dequeue();
            yt.Dequeue();
            yt.Dequeue();
            yt.Dequeue();

            Console.WriteLine(yt.Peek());
        }
    }
}
