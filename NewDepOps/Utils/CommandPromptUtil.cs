using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DotNet.Cli.Utils;

namespace NewDepOps.Utils
{
    public class CommandPromptUtil
    {
        public static int RunCommand(string command, string workingDirectory)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new Exception($"Command is null or empty.");
            }

            var stdOut = new StringBuilder();
            var stdErr = new StringBuilder();


            var result = Command.Create("cmd", new[] { workingDirectory, command })
            .WorkingDirectory(workingDirectory)
            .CaptureStdOut()
            .CaptureStdErr()
            .OnErrorLine(line =>
            {
                Console.Error.WriteLine(line);
                stdErr.AppendLine(line);
            })
            .OnOutputLine(line =>
            {
                Console.WriteLine(line);
                stdOut.AppendLine(line);
            })
            .Execute();

            //Can not handle error. On error we just has opened console

            //Console.WriteLine($"Exit code: {result.ExitCode}");

            //if (!result.WA(TimeSpan.FromSeconds(30)))
            //{
            //    // Process did not exit before the timeout, kill it
            //    process.KillTree();
            //}

            return 1;

            //return result.ExitCode;
        }
    }
}
