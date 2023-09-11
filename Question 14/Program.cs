using System;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            GSMTest gSMTest = new GSMTest();
            gSMTest.Create();
            GSM gSM = new GSM();
            gSM.DisplayNokia();
            Console.WriteLine("Hello World!");
        }
    }
}
