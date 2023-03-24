using NewDepOps.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewDepOps.Utils;
using NewDepOps.Configs.ParamsConfigs.DotNetFrameWorkPublishService;
using NewDepOps.Configs.ParamsConfigs.GitService;

namespace NewDepOps.Services
{
    public class DotNetFrameWorkPublishService : IStepService
    {
        public string Name => "DotNetFrameWorkPublishService";
        public async Task ExecuteAsync(List<MethodConfig> methods)
        {
            //Not the most elegant solution, but using switch/case is very simple and readable
            foreach (var method in methods)
            {
                switch (method.Name)
                {
                    case "Publish":
                        var paramsConfig = method.Params!.ToObject<PublishParamsConfig>();
                        if (paramsConfig != null)
                        {
                            Publish(paramsConfig.ProjectDirectory, paramsConfig.PublishDirectory);
                        }
                        break;
                }
            }
        }

        private void Publish(string projectDirectory, string publishDirectory)
        {
            //CommandPromptUtil.RunCommand($"dotnet publish {projectDirectory} -c Release --output {publishDirectory}", projectDirectory);
            Console.WriteLine("Publish here"); 
            Console.WriteLine($"{projectDirectory}, {publishDirectory}");
        }
    }
}
