using Microsoft.Extensions.DependencyInjection;
using NewDepOps.Configs;
using NewDepOps.Services;
using Newtonsoft.Json;

var services = new ServiceCollection();
services.AddSingleton<IStepService, GitService>();
services.AddSingleton<IStepService, DotNetFrameWorkPublishService>();

var serviceProvider = services.BuildServiceProvider();
var appServices = serviceProvider.GetServices<IStepService>();

Console.WriteLine("Select project");
Console.WriteLine("1. Auto Front");
Console.WriteLine("2. Second Project");
int.TryParse(Console.ReadLine()!.ToString(), out int selectedOption);

string profileFilePath = string.Empty;
switch (selectedOption)
{
    //Add relative path
    case 1:
        profileFilePath = @"D:\PersonalDevelopment\NewDepOps\NewDepOps\Profiles\auto_front.settings.json";
        break;
    case 2:
        profileFilePath = @"D:\PersonalDevelopment\NewDepOps\NewDepOps\Profiles\second_project.settings.json";
        break;
    default:
        Console.WriteLine("Invalid input, please try again.");
        Environment.Exit(-1);
        break;
}

using (StreamReader file = File.OpenText(profileFilePath))
{
    var serializer = new JsonSerializer();
    var profile = serializer.Deserialize(file, typeof(ProfileConfig)) as ProfileConfig;

    if (profile != null)
    {
        foreach (var step in profile.Steps)
        {
            var service = appServices.FirstOrDefault(x => x.Name.Equals(step.Name));
            if (service != null)
            {
                await service.ExecuteAsync(step.Methods);
            }
        }
    }
}
