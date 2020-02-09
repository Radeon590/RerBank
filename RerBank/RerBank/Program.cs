using System;

namespace RerBank
{
    class Program
    {
        public static bool work = true;

        static void Main(string[] args)
        {
            while (work == true) {
                Keys KK = new Keys(Console.ReadKey(true).KeyChar);
                KK.keyKnow();
            }
        }
    }
}    
