using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDepOps.Configs
{
    public class ProfileConfig : IConfig
    {
        public string Name { get; set; } = null!;
        public List<StepConfig> Steps { get; set; } = new List<StepConfig>();
    }
}
