using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BackwoodsMapleTracker
{
    class Database
    {
        public int pintBottlesAvail { get; set; }
        public int halfPintBottlesAvail { get; set; }
        public int quartBottlesAvail { get; set; }
        public ObservableCollection<DailySyrupProductionRecord> dailySyrupProducedList { get; set; }
        public ObservableCollection<DailyCostRecord> dailyCostList { get; set; }


    }
}
