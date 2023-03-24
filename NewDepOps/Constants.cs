using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDepOps
{
    public static class Constants
    {
        public static readonly Signature Signature = new Signature("Your Name", "youremail@example.com", DateTimeOffset.Now);
    }
}
