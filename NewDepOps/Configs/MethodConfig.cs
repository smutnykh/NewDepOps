using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDepOps.Configs
{
    public class MethodConfig : IConfig
    {
        public string Name { get; set; } = null!;
        public JObject? Params { get; set; }
    }
}
