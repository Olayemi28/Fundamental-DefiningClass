using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("Infinix X657C", "Android", 75000.00m, "INFINIX");
            Console.WriteLine(gsm.ToString());
        }
    }
}
