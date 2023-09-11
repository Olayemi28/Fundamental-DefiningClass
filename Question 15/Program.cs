using System;

namespace Question_15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime dt = new DateTime(2012, 01, 01);
            TimeSpan ts = new TimeSpan(1, 0, 0, 0, 0);
            dt = dt + ts;
            Console.WriteLine(dt);
        }
    }
}
