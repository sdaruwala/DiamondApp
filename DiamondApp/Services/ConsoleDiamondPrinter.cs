using DiamondApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondApp.Services
{
    public class ConsoleDiamondPrinter : IDiamondPrinter
    {
        public void PrintDiamond(string[] diamondRows)
        {
            foreach (var row in diamondRows)
            {
                Console.WriteLine(row);
            }
        }
    }
}
