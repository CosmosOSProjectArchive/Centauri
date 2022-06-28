using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Centauri.Utils;
using Centauri.Shell;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;

// Yes, I will comment this better so the code is actually understandable.
// And yes, the code is trash.

namespace Centauri
{
    public class Kernel : Sys.Kernel
    {
        // This is honestly just here for aesthetic purposes
        public static string user = "root";
        public static string host = "centauri";
        public static readonly string version = "0.0.1";
        public static readonly string osname = "Centauri";
        protected override void BeforeRun()
        {
            CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Directory.SetCurrentDirectory("0:\\");
            Log.Info("VFS Registered");
            Log.Info("Centauri Kernel Loaded");
        }

        protected override void Run()
        {
            try
            {
                // To save the headache, this just prints:
                // [centauri@root:0:\]
                // Well, with cool colors and stuff
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(host);
                Console.Write("@");
                Console.Write(user);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(':');
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(Directory.GetCurrentDirectory());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] ");

                string input = Console.ReadLine();

                Shell.Shell.Run(input);
            }
            catch(Exception)
            {
                
            }
        }
    }
}
