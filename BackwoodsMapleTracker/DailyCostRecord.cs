using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackwoodsMapleTracker
{
    class DailyCostRecord
    {
        public string date { get; }
        public string name { get; }
        public double cost { get; }

        public DailyCostRecord(string dateValue, string nameValue, double costValue)
        {
            date = dateValue;
            name = nameValue;
            cost = costValue;
        }
    }
}
