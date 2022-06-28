using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centauri.Utils;
using Centauri.Applications.Editor;
using System.IO;
using Sys = Cosmos.System;
using Core = Cosmos.Core;
using HAL = Cosmos.HAL;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;

namespace Centauri.Shell
{
    public class Shell
    {
        private static List<string> clipboard = new List<string>();
        private static void CopyDirectory(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }
        public static void Run(string command)
        {
            List<string> arguments = new List<string>();
            StringBuilder arg = new StringBuilder();
            command = command.Trim(' ');

            for (int i = 0; i < command.Length + 1; i++)
            {
                if (command[i] == ' ' || command[i] == '\0')
                {
                    arguments.Add(arg.ToString());
                    arg.Clear();
                }
                else if (command[i] == '\"')
                {
                    i++;
                    while (command[i] != '\"')
                    {
                        arg.Append(command[i]);
                        i++;
                    }
                }
                else
                {
                    arg.Append(command[i]);
                }
            }

            Handler(ref arguments);

            arguments.Clear();
        }
        private static void Handler(ref List<string> arguments)
        {
            switch(arguments[0].ToLower())
            {
                case "pwd":
                    Console.WriteLine(Directory.GetCurrentDirectory());
                    break;
                case "fetch":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("      xxxxx           ");
                    Console.Write    ("     @xxxxx@          ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0}@{1}", Kernel.host, Kernel.user);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    @xxxxxxx@         ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   @xxxxxxxxx@        ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("OS: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Kernel.osname);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" @xxxxxxxxxxxxx@      ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Kernel: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Kernel.version);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" xxxx   xxxxxxxx      ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("CPU: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Core.CPU.GetCPUBrandString());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" xxx xxxxx   xxx      ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Memory: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0} / {1} bytes", Core.GCImplementation.GetUsedRAM() / 1024, Core.GCImplementation.GetAvailableRAM() * 1024);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" xxx xxxxx xx xx      ");
                    Console.WriteLine(" xxx xxxxx xx xx      ");
                    Console.WriteLine(" @xxx   xx xx x@      ");
                    Console.WriteLine("  @xxxxxxxxxxx@       ");
                    Console.WriteLine("   @xxxxxxxxx@        ");
                    Console.WriteLine("    @xxxxxxx@         ");
                    Console.Write    ("     @xxxxx@          ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("###");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("      xxxx@           ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("###");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("###");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "miv":
                case "write":
                    if (arguments.Count() > 1)
                    {
                        MIV.Run(Path.GetFullPath(arguments[1]));
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }
                    break;
                case "clip":
                    switch (arguments[1].ToLower())
                    {
                        case "clear":
                            clipboard.Clear();
                            break;
                        case "add":
                            for(int i = 2; i < arguments.Count(); i++)
                            {
                                clipboard.Add(arguments[i]);
                            }
                            break;
                        case "view":
                            foreach(string element in clipboard)
                            {
                                Console.WriteLine(element);
                            }
                            break;
                        case "save":
                            File.Create("0:\\clipboard.txt");
                            foreach (string element in clipboard)
                            {
                                File.WriteAllLines("0:\\clipboard.txt", clipboard);
                            }
                            break;
                        default:
                            Log.Error("Unknown option");
                            break;
                    }
                    break;
                case "rm":
                    if (arguments.Count() > 1)
                    {
                        for (int i = 1; i < arguments.Count(); i++)
                        {
                            if (File.Exists(Path.GetFullPath(arguments[i])))
                            {
                                try
                                {
                                    File.Delete(arguments[i]);
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex.Message);
                                }
                            }
                            else
                            {
                                Log.Error(String.Format("'{0}' does not exist", arguments[i]));
                            }
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }
                    break;
                case "rmdir":
                    if (arguments.Count() > 1)
                    {
                        for (int i = 1; i < arguments.Count(); i++)
                        {
                            if (Directory.Exists(Path.GetFullPath(arguments[i])))
                            {
                                try
                                {
                                    Directory.Delete(arguments[i], true);
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex.Message);
                                }
                            }
                            else
                            {
                                Log.Error(String.Format("'{0}' does not exist", arguments[i]));
                            }
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }
                    break;
                case "info":
                    Log.Error("Command unsupported, waiting for a FileInfo plug (I could do something but im lazy)");
                    /*if (arguments.Count() > 1)
                    {
                        foreach (string arg in arguments)
                        {
                            Console.WriteLine(arg);
                            if (File.Exists(Path.GetFullPath(arg)))
                            {
                                FileInfo fileInfo = new FileInfo(Path.GetFullPath(arg));
                                Console.WriteLine("Name: " + fileInfo.Name);
                                Console.WriteLine("Full Name: " + fileInfo.FullName);
                                Console.WriteLine("Directory Name: " + fileInfo.DirectoryName);
                                Console.WriteLine("Size: " + fileInfo.Length);
                                Console.WriteLine("Creation Time: " + fileInfo.CreationTime.ToString("MM/dd/yyyy HH:mm:ss"));
                                Console.WriteLine("Last Write Time: " + fileInfo.LastWriteTime.ToString("MM/dd/yyyy HH:mm:ss"));
                                Console.WriteLine("Last Access Time: " + fileInfo.LastAccessTime.ToString("MM/dd/yyyy HH:mm:ss"));
                                Console.WriteLine("Readonly: " + fileInfo.IsReadOnly);
                                Console.WriteLine("Extension: " + fileInfo.Extension);

                            }
                            if (Directory.Exists(Path.GetFullPath(arg)))
                            {
                                DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetFullPath(arg));
                                Console.WriteLine("Name: " + directoryInfo.Name);
                                Console.WriteLine("Full Name: " + directoryInfo.FullName);
                                Console.WriteLine("Root: " + directoryInfo.Root);
                                Console.WriteLine("Parent: " + directoryInfo.Parent);
                                Console.WriteLine("Last Write Time: " + directoryInfo.LastWriteTime.ToString("MM/dd/yyyy HH:mm:ss"));
                                Console.WriteLine("Last Access Time: " + directoryInfo.LastAccessTime.ToString("MM/dd/yyyy HH:mm:ss"));
                                Console.WriteLine("Extention: " + directoryInfo.Extension);
                            }
                            else
                            {
                                Log.Error("Path does not exist");
                            }
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }*/
                    break;
                case "move":
                case "mv":
                    Log.Error("Command unsupported, waiting for a File.Move plug (I could do something but im lazy)");
                    /*if (arguments.Count() > 1)
                    {
                        for (int i = 1; i < arguments.Count() - 1; i++)
                        {
                            if (File.Exists(Path.GetFullPath(arguments[i])))
                            {
                                File.Move(arguments[i], arguments[arguments.Count() - 1]);
                            }
                            if (Directory.Exists(Path.GetFullPath(arguments[i])))
                            {
                                Directory.Move(arguments[i], arguments[arguments.Count() - 1]);
                            }
                            else
                            {
                                Log.Error(String.Format("'{0}' doesn't exist", arguments[i]));
                            }
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }*/
                    break;
                case "copy":
                case "cp":
                    Log.Error("Command unsupported, waiting for a File.Copy plug (I could do something but im lazy)");
                    /*if (arguments.Count() > 1)
                    {
                        for (int i = 1; i < arguments.Count() - 1; i++)
                        {
                            if (File.Exists(Path.GetFullPath(arguments[i])))
                            {
                                File.Copy(arguments[i], arguments[arguments.Count() - 1]);
                            }
                            if (Directory.Exists(Path.GetFullPath(arguments[i])))
                            {
                                CopyDirectory(arguments[i], arguments[arguments.Count() - 1]);
                            }
                            else
                            {
                                Log.Error(String.Format("'{0}' doesn't exist", arguments[i]));
                            }
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }*/
                    break;
                case "mkfile":
                case "touch":
                    if (arguments.Count() > 1)
                    {
                        for (int i = 1; i < arguments.Count(); i++)
                        {
                            if (File.Exists(Path.GetFullPath(arguments[i])))
                            {
                                Log.Error(String.Format("'{0}' already exists", arguments[i]));
                            }
                            else
                            {
                                File.Create(arguments[i]);
                            }
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }
                    break;
                case "md":
                case "mkdir":
                    if (arguments.Count() > 1)
                    {
                        for (int i = 1; i < arguments.Count(); i++)
                        {
                            if (Directory.Exists(Path.GetFullPath(arguments[i])))
                            {
                                Log.Error(String.Format("'{0}' already exists", arguments[i]));
                            }
                            else
                            {
                                Directory.CreateDirectory(arguments[i]);
                            }
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }
                    break;
                case "cd":
                    if (arguments.Count() > 1)
                    {
                        if (Directory.Exists(Path.GetFullPath(arguments[1])))
                        {
                            Directory.SetCurrentDirectory(Path.GetFullPath(arguments[1]));
                        }
                        else
                        {
                            Log.Error(String.Format("'{0}' does not exist", arguments[1]));
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }
                    break;
                case "type":
                case "read":
                case "cat":
                    if (arguments.Count() > 1)
                    {
                        for (int i = 1; i < arguments.Count(); i++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(arguments[i]);
                            Console.ForegroundColor = ConsoleColor.White;
                            if (File.Exists(Path.GetFullPath(arguments[i])))
                            {
                                Console.WriteLine(File.ReadAllText(Path.GetFullPath(arguments[i])));
                            }
                            else
                            {
                                Log.Error(String.Format("'{0}' does not exist", arguments[i]));
                            }
                        }
                    }
                    else
                    {
                        Log.Error("Insufficent number of arguments");
                    }
                    break;
                case "shutdown":
                    Sys.Power.Shutdown();
                    break;
                case "mem":
                case "ram":
                    Console.WriteLine("{0} mb", Core.GCImplementation.GetAvailableRAM());
                    break;
                case "cpuinfo":
                    Console.WriteLine("Brand String: {0}", Core.CPU.GetCPUBrandString());
                    Console.WriteLine("Uptime: {0}", Core.CPU.GetCPUUptime());
                    /*Console.WriteLine("Cycle Speed: {0}" + Core.CPU.GetCPUCycleSpeed());*/
                    Console.WriteLine("Vendor Name: {0}", Core.CPU.GetCPUVendorName());
                    break;
                case "reset":
                case "reboot":
                    Sys.Power.Reboot();
                    break;
                case "cls":
                case "clr":
                case "clear":
                    Console.Clear();
                    break;
                case "disks":
                    Log.Error("Not implemented yet");
                    break;
                case "dir":
                case "ls":
                    if (arguments.Count() > 1)
                    {
                        for (int i = 1; i < arguments.Count(); i++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(arguments[i]);
                            Console.ForegroundColor = ConsoleColor.White;
                            if (Directory.Exists(arguments[i]))
                            {
                                foreach (var entry in Directory.GetDirectories(arguments[i]))
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(entry);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                foreach (var entry in Directory.GetFiles(arguments[i]))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(entry);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            else
                            {
                                Log.Error(String.Format("'{0}' does not exist", arguments[i]));
                            }
                        }
                    }
                    else
                    {
                        if (Directory.Exists(Directory.GetCurrentDirectory()))
                        {
                            foreach (var entry in Directory.GetDirectories(Directory.GetCurrentDirectory()))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(entry);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            foreach (var entry in Directory.GetFiles(Directory.GetCurrentDirectory()))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(entry);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        else
                        {
                            Log.Error(String.Format("'{0}' does not exist", Directory.GetCurrentDirectory()));
                        }
                    }
                    break;
                case "version":
                case "ver":
                    Console.WriteLine("{0} v{1}", Kernel.osname, Kernel.version);
                    break;
                case "help":
                    if (arguments.Count() > 1)
                    {
                        Help.HelpCommand(arguments[1]);
                    }
                    else
                    {
                        Help.HelpMessage();
                    }
                    break;
                default:
                    Log.Error("Unknown command");
                    break;
            }
        }
    }
}
