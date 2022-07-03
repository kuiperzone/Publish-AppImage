// #############################################################################
// PROJECT   : Publish-AppImage for .NET
// WEBPAGE   : https://github.com/kuiperzone/Publish-AppImage
// COPYRIGHT : Andy Thomas 2021-2022
// LICENSE   : MIT
// #############################################################################

using System;
using System.IO;
using System.Reflection;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(nameof(HelloWorld));
            Console.WriteLine("Version: {0}", GetVersion());
            Console.WriteLine();

            // Ensure arguments are passed
            Console.WriteLine("ARGS: {0}", string.Join(", ", args));

            // Working directory
            Console.WriteLine("PWD: {0}", Directory.GetCurrentDirectory());
            Console.WriteLine();

            // Executable directory
            Console.WriteLine("AppDomain.CurrentDomain.BaseDirectory: {0}", AppDomain.CurrentDomain.BaseDirectory);

            // Executable path (warning IL3000 for "single-file" is expected)
            Console.WriteLine("Assembly.GetEntryAssembly().Location: {0}", Assembly.GetEntryAssembly()?.Location ?? "null");
            Console.WriteLine();

            Console.WriteLine("Press any key to finish");
            Console.ReadKey(false);
            Console.WriteLine();
        }

        private static string GetVersion()
        {
            try
            {
                // Wasn't expecting this to work for:
                // -p:PublishSingleFile=true
                // But it seems to work OK
                var ea = Assembly.GetEntryAssembly();

                if (ea != null)
                {
                    var ver = ea.GetName().Version;

                    if (ver != null)
                    {
                        return ver.ToString();
                    }

                    throw new Exception($"{ver} is null");
                }

                throw new Exception($"{ea} is null");
            }
#if DEBUG
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
#else
            catch
            {
            }
#endif

            // Fallback
            return "Unknown";
        }
    }

}
