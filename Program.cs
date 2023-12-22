using System;

namespace dockerable
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Hello World!\n");
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
