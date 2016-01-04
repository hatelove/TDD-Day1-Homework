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
        //有可能傳入的data長度是不一樣的，這樣子是用4個column來當資料，而不是用11筆row來當資料
        
        public void AddColumn(string header, List<int> data)
        {
            table[header] = data;
        }
        
        //取得資料應該是取得11筆資料，而不是取得某一欄的資料。例如延伸一個新的需求，要算出每個grouping的毛利平均，毛利是SellPrice/Cost。
        //目前這樣的設計無法一次取得兩個 column 來運算。
        public List<int> GetColumnData(string header)
        {
            return table[header];
        }
    }
}
