using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDepOps.Configs.ParamsConfigs.GitService
{
    public class PullChangesParamsConfig
    {
        public string SourceDirectory { get; set; } = null!;
        public string BranchName { get; set; } = null!;
    }
}
