using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centauri.Shell
{
    // Ansi color codes things wont work so here is my terrible implementation of it
    // Doesn't parse background yet, ill do that later
    // I'll improve this later
    public class Ansi
    {
        public static void Color(string code)
        {
            switch(code)
            {
                case "30":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "31":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "32":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "33":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "34":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "35":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "36":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "37":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "90":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "91":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "92":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "93":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "94":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "95":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "96":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "97":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        public static void Write(string format)
        {
            StringBuilder code = new StringBuilder();
            for (int i = 0; i < format.Length; i++)
            {
                if(format[i] == '\u001b')
                {
                    i++;
                    if (format[i] == '[')
                    {
                        i++;
                        while(format[i] != 'm')
                        {
                            code.Append(format[i]);
                            i++;
                        }
                        Color(code.ToString());
                        code.Clear();
                    }
                }
                else
                {
                    Console.Write(format[i]);
                }
            }
        }
        public static void WriteLine(string format)
        {
            Write(format);
            Console.Write('\n');
        }
    }
}
