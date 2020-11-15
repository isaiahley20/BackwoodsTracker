using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BackwoodsMapleTracker
{
    class Control
    {
        Database dataBase = new Database();
        public string mostRecentSapOverSyrupRatio()
        {
            ObservableCollection<DailySyrupProductionRecord> dailyCostList = getDailySyrupProducedList();
            int i = dailyCostList.Count();
            DailySyrupProductionRecord mostRecent = dailyCostList.ElementAt(i-1);
            return mostRecent.syrupSapRatio;
        }
        public string calcExpectedNextSapOverSyrupRatio()
        {
            return "1/100";
        }
        public int getPintBottlesAvail()
        {
            return dataBase.pintBottlesAvail;
        }
        public int getHalfPintBottlesAvail()
        {
            return dataBase.halfPintBottlesAvail;
        }
        public int getQuartBottlesAvail()
        {
            return dataBase.quartBottlesAvail;
        }
        public ObservableCollection<DailySyrupProductionRecord> getDailySyrupProducedList()
        {
            return dataBase.dailySyrupProducedList;
        }
        public ObservableCollection<DailyCostRecord> getDailyCostList()
        {
            return dataBase.dailyCostList;
        }

    }
}
