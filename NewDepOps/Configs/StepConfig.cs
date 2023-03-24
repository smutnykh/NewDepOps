using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDepOps.Configs
{
    public class StepConfig : IConfig
    {
        public string Name { get; set; } = null!;
        public List<MethodConfig> Methods { get; set; } = new List<MethodConfig>();
    }
}
