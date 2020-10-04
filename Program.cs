using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace realsteamcmd
{
    class Program
    {
        public static void Listen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Steam>");
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            switch (split[0])
            {
                case "help":
                    if (split.Length > 1)
                    {
                        Console.WriteLine($@"No specific help topic found for '{split[1]}', returning 'find' results. . .
ConVars:
Commands:
");
                        return;
                    }
                    Console.WriteLine(Strings.helpmsg);
                    break;

                case "quit":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine($"Command not found: {input}\n");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Strings.intro);
            for(; ; )
            {
                Listen();
            }
        }
    }
}
