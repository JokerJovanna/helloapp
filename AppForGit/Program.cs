using System;

namespace HelloApp
{
    class Program
    {
        public static void greetBlack()
        {
            Console.WriteLine("hello black");
        }

        public static void greetWhite()
        {
            Console.WriteLine("hello white");
        }

        static void Main()
        {
            Console.WriteLine("hello everyone");
            greetBlack();
            greetWhite();
        }
    }
}
