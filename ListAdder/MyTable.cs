using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAdder
{
    public class MyTable
    {
        private Dictionary<string, List<int>> table = new Dictionary<string, List<int>>();
        public void AddColumn(string header, List<int> data)
        {
            table[header] = data;
        }
        public List<int> GetColumnData(string header)
        {
            return table[header];
        }
    }
}
