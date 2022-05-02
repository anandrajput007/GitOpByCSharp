using System;
using System.Collections.Generic;

namespace GitOpByCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string localPath = @"F:\MYGit\ARTypescript";
            List<string> lstBranchs = GitOperations.GetAllBranchName(localPath);
            foreach (var branch in lstBranchs)
            {
                Console.WriteLine(branch);
            }
            Console.ReadLine();
        }
    }
}
