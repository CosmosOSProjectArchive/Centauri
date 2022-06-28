// Logs stuff
using System;

namespace Centauri.Utils
{
    public class Log
    {
        public static void Debug(
            string format,
            [System.Runtime.CompilerServices.CallerMemberName] string function = "",
            [System.Runtime.CompilerServices.CallerFilePath] string file = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int line = 0
            )
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(DateTime.Now.ToString("HH:mm:ss"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" DEBUG ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(file.Substring(file.LastIndexOf('\\') + 1) + ":" + function + ":" + line + " ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(format);
        }
        public static void Warn(
            string format,
            [System.Runtime.CompilerServices.CallerMemberName] string function = "",
            [System.Runtime.CompilerServices.CallerFilePath] string file = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int line = 0
            )
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(DateTime.Now.ToString("HH:mm:ss"));

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" WARN ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(file.Substring(file.LastIndexOf('\\') + 1) + ":" + function + ":" + line + " ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(format);
        }
        public static void Error(
            string format,
            [System.Runtime.CompilerServices.CallerMemberName] string function = "",
            [System.Runtime.CompilerServices.CallerFilePath] string file = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int line = 0
            )
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(DateTime.Now.ToString("HH:mm:ss"));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ERROR ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(file.Substring(file.LastIndexOf('\\') + 1) + ":" + function + ":" + line + " ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(format);
        }

        public static void Info(
            string format,
            [System.Runtime.CompilerServices.CallerMemberName] string function = "",
            [System.Runtime.CompilerServices.CallerFilePath] string file = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int line = 0
            )
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(DateTime.Now.ToString("HH:mm:ss"));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" INFO ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(file.Substring(file.LastIndexOf('\\') + 1) + ":" + function + ":" + line + " ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(format);
        }
    }
}
