using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertEnvironmentVariables
{
    internal class Insert
    {
        public void InsertVariable()
        {
            string txtFile = $"{Environment.CurrentDirectory}/txtFile.txt";
            Console.WriteLine(txtFile);
            Console.WriteLine();
            string[] lines = File.ReadAllLines("");
        }

    }
}
