using System;

namespace RerBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Keys KK = new Keys(Console.ReadKey(true).KeyChar);
            KK.keyKnow();
        }
    }
}
