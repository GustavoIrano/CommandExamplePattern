using System;

namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Add("I");
            Console.ReadKey();
            user.Add("'");
            Console.ReadKey();
            user.Add("m");
            Console.ReadKey();
            user.Add("hungry");
            Console.ReadKey();
            user.Add("!");
            Console.ReadKey();

            user.ExecuteAllCommands(5);
        }
    }
}
