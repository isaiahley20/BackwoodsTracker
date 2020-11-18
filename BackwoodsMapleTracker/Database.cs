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
        public ObservableCollection<DailySyrupProductionRecord> dailySyrupProducedList = new ObservableCollection<DailySyrupProductionRecord>();
        public ObservableCollection<DailyCostRecord> dailyCostList = new ObservableCollection<DailyCostRecord>();

        public void LoadDailySyrupProducedList()
        {
            dailySyrupProducedList.Add(new DailySyrupProductionRecord("10/11/2020", 1, 28));
            dailySyrupProducedList.Add(new DailySyrupProductionRecord("10/12/2020", 2, 29));
            dailySyrupProducedList.Add(new DailySyrupProductionRecord("10/13/2020", 2, 30));
        }
        public void LoadDailyCostList()
        {
            dailyCostList.Add(new DailyCostRecord("10/11/2020", "Liquid Propane", 150.57));
            dailyCostList.Add(new DailyCostRecord("10/12/2020", "Jars", 32.78));
        }

        public ObservableCollection<DailySyrupProductionRecord> getDailySyrupProducedList()
        {
            return dailySyrupProducedList;
        }

        public ObservableCollection<DailyCostRecord> getDailyCostList()
        {
            return dailyCostList;
        }

    }
}
