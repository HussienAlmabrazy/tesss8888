using System;
using System.Threading;

namespace CSharpTutorial
{
    class Program
    {
        static void fun()
        {

        }
        public static void Main()
        {
            Thread t = new Thread(fun);
            Console.WriteLine(t.ThreadState);
            t.Name = "the5";
            t.IsBackground = true;
            t.Start();
            Console.WriteLine(t.ThreadState);
            t.Join();
            Console.WriteLine(t.ThreadState);
            if (!t.IsAlive)
            {
                t.Start();
            }
            Console.WriteLine(t.IsBackground);
            Console.ReadLine();
        }

    }
       
    
}