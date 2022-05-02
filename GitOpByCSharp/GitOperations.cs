using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitOpByCSharp
{
    public static class GitOperations
    {
        public static List<string> GetAllBranchName(string localPath)
        {
            List<string> lstBranch = new List<string>();
            try
            {
                using (var repo = new Repository(localPath))
                {
                    var branches = repo.Branches;
                    foreach (var b in branches)
                    {
                        lstBranch.Add(b.FriendlyName);
                    }
                }
            }
            catch
            {
                throw;
            }

            return lstBranch;
        }
    }
}
