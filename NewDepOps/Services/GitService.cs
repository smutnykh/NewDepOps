using LibGit2Sharp;
using NewDepOps.Configs;
using NewDepOps.Configs.ParamsConfigs.GitService;

namespace NewDepOps.Services
{
    public class GitService : IStepService
    {
        public string Name => "GitService";
        public async Task ExecuteAsync(List<MethodConfig> methods)
        {
            //Not the most elegant solution, but using switch/case is very simple and readable
            foreach(var method in methods)
            {
                switch(method.Name)
                {
                    case "PullChanges":
                        var paramsConfig = method.Params!.ToObject<PullChangesParamsConfig>();
                        if (paramsConfig != null)
                        {
                            PullChanges(paramsConfig.SourceDirectory, paramsConfig.BranchName);
                        }
                        break;
                }
            }
        }

        private void PullChanges(string sourceDirectory, string branchName)
        {
            //using (var repo = new Repository(sourceDirectory))
            //{
            //    Branch branch = repo.Branches[branchName];

            //    if (!branch.IsTracking)
            //    {
            //        throw new LibGit2SharpException("There is no tracking information for the current branch.");
            //    }

            //    if (branch.RemoteName == null)
            //    {
            //        throw new LibGit2SharpException("No upstream remote for the current branch.");
            //    }

            //    Commands.Checkout(repo, branchName);
            //    var options = new PullOptions();

            //    Commands.Fetch(repo, branch.RemoteName, new string[0], options.FetchOptions, null);
            //    repo.MergeFetchedRefs(Constants.Signature, options.MergeOptions);

            //    //Check for status
            //}
            Console.WriteLine("PullChanges here");
            Console.WriteLine($"{sourceDirectory}, {branchName}");
        }
    }
}
