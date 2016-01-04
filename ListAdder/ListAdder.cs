using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAdder
{
    public class ListAdder
    {
        public List<int> Sigma(MyTable table, string header, int num_per_group)
        {
            var list = new List<int>();
            var data = table.GetColumnData(header);
            if (data != null)
            {
                var sum = 0;
                for (int i = 0; i < data.Count; ++i)
                {
                    sum += data[i];
                    if ((i + 1) % num_per_group == 0)
                    {
                        list.Add(sum);
                        sum = 0;
                    }
                }
                if (sum != 0)
                {
                    list.Add(sum);
                }
            }
           
            return list;
        }

        static void Main(string[] args)
        {

        }
    }
    
}
