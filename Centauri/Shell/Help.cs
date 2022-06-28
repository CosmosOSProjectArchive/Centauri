using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centauri.Utils;

namespace Centauri.Shell
{
    public class Help
    {
        public static void HelpMessage()
        {
            /* help - Prints this message
             * pwd - Prints working directory 
             * fetch - Walmart neofetch
             * miv/write - Opens up the MIV editor
             * clip - A"clipboard"
             * rm - Removes file
             * rmdir - Removes directory, recursively
             * info - Not implemented yet
             * mv/move - Not implemented yet
             * cp/copy - Not implemented yet
             * touch/mkfile - Creates a file
             * mkdir/md - Creates a directory
             * cd - Changes current directory
             * cat/type/read - Reads a file
             * shutdown - Shuts down the system
             * mem/ram - Gets total RAM
             * cpuinfo - Shows CPU information
             * reset/reboot - Reboots the system
             * clear/cls/clr - Clears the screen
             * disks - Not implemented yet
             * ls/dir - Lists all directory entries
             * Doing help [command] will show the options for the command
             */
            Console.WriteLine("Centauri Help Page:");
            Console.WriteLine("help - Prints this message");
            Console.WriteLine("pwd - Prints working directory");
            Console.WriteLine("fetch - Walmart neofetch");
            Console.WriteLine("miv/write - Opens up the MIV editor");
            Console.WriteLine("clip - A \"clipboard\"");
            Console.WriteLine("rm - Removes file");
            Console.WriteLine("rmdir - Removes directory, recursively");
            Console.WriteLine("info - Not implemented yet");
            Console.WriteLine("mv/move - Not implemented yet");
            Console.WriteLine("cp/copy - Not implemented yet");
            Console.WriteLine("touch/mkfile - Creates a file");
            Console.WriteLine("mkdir/md - Creates a directory");
            Console.WriteLine("cd - Changes current directory");
            Console.WriteLine("cat/type/read - Reads a file");
            Console.WriteLine("shutdown - Shuts down the system");
            Console.WriteLine("mem/ram - Gets total RAM");
            Console.WriteLine("cpuinfo - Shows CPU information");
            Console.WriteLine("reset/reboot - Reboots the system");
            Console.WriteLine("clear/cls/clr - Clears the screen");
            Console.WriteLine("disks - Not implemented yet");
            Console.WriteLine("ls/dir - Lists all directory entries");
            Console.WriteLine("version/ver - Shows the version along with the os name");
            Console.WriteLine("Doing help [command] will show the options for the command");
        }
        public static void HelpCommand(string command)
        {
            switch (command)
            {
                case "pwd":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("pwd - Prints the working directory");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] pwd");
                    Console.WriteLine();
                    break;
                case "fetch":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("fetch - Walmart neofetch");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] fetch");
                    Console.WriteLine();
                    break;
                case "miv":
                case "write":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("miv/write - Opens up the MIV editor");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] miv");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] write");
                    Console.WriteLine();
                    break;
                case "clip":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("clip - A \"clipboard\"");
                    Console.WriteLine("clip clear - Clears clipboard");
                    Console.WriteLine("clip add - Adds to clipboard");
                    Console.WriteLine("clip view - Views clipboard");
                    Console.WriteLine("clip save - Saves clipboard in '0:\\appdata\\clipboard.cbs'");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] clip clear");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] clip add multiple elements");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] clip view");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] clip save");
                    Console.WriteLine();
                    break;
                case "rm":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("rm - Removes file");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] rm");
                    Console.WriteLine();
                    break;
                case "rmdir":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("rmdir - Removes directory, recursively");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] rmdir");
                    Console.WriteLine();
                    break;
                case "info":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("info - Not implemented yet");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] info");
                    Console.WriteLine();
                    break;
                case "move":
                case "mv":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("mv/move - Not implemented yet");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] mv source.txt source2.txt dest");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] move source.txt source2.txt dest");
                    Console.WriteLine();
                    break;
                case "copy":
                case "cp":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("cp/copy - Not implemented yet");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] cp source.txt source2.txt dest");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] copy source.txt source2.txt dest");
                    Console.WriteLine();
                    break;
                case "mkfile":
                case "touch":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("touch/mkfile - Creates a file");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] mkfile file.txt file2.txt");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] touch file.txt file2.txt");
                    Console.WriteLine();
                    break;
                case "md":
                case "mkdir":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("mkdir/md - Creates a directory");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] mkdir dir dir2");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] md dir dir2");
                    Console.WriteLine();
                    break;
                case "cd":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("cd - Changes current directory");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] cd dir");
                    Console.WriteLine();
                    break;
                case "type":
                case "read":
                case "cat":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("cat/type/read - Reads a file");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] cat file.txt file2.txt");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] type file.txt file2.txt");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] read file.txt file2.txt");
                    Console.WriteLine();
                    break;
                case "shutdown":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("shutdown - Shuts down the system");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] shutdown");
                    Console.WriteLine();
                    break;
                case "mem":
                case "ram":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("mem/ram - Gets total RAM");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] mem");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] ram");
                    Console.WriteLine();
                    break;
                case "cpuinfo":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("cpuinfo - Shows CPU information");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] cpuinfo");
                    Console.WriteLine();
                    break;
                case "reset":
                case "reboot":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("reset/reboot - Reboots the system");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] reset");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] reboot");
                    Console.WriteLine();
                    break;
                case "cls":
                case "clr":
                case "clear":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("clear/cls/clr - Clears the screen");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] clear");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] cls");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] clr");
                    Console.WriteLine();
                    break;
                case "disks":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("disks - Not implemented yet");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] disks");
                    Console.WriteLine();
                    break;
                case "dir":
                case "ls":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("ls/dir - Lists all directory entries");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] ls");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] dir");
                    Console.WriteLine();
                    break;
                case "version":
                case "ver":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("version/ver - Shows the version along with the os name");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] version");

                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] ver");
                    Console.WriteLine();
                    break;
                case "help":
                    Console.WriteLine("Centauri Help Page:");
                    Console.WriteLine("help - Prints this message");
                    Console.WriteLine("Example(s):");
                    Console.Write("$ [");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("centauri");
                    Console.Write("@");
                    Console.Write("root");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(':');
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("0:\\");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("] help");
                    Console.WriteLine();
                    break;
                default:
                    HelpMessage();
                    break;
            }
        }
    }
}
