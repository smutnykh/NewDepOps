using Newtonsoft.Json.Linq;
using LibGit2Sharp;
using System.Threading.Tasks;
using NewDepOps.Configs;

namespace NewDepOps.Services
{
    public interface IStepService
    {
        string Name { get; }
        Task ExecuteAsync(List<MethodConfig> methods);
    }
}
