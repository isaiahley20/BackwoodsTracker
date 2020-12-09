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
        public Control()
        {
            dataBase.LoadDailySyrupProducedList();
            dataBase.LoadDailyCostList();
        }

        //gets the most recent sap over syrup ratio
        public string MostRecentSapOverSyrupRatio()
        {
            ObservableCollection<DailySyrupProductionRecord> dailySyrupProductionList = GetDailySyrupProducedList();
            DailySyrupProductionRecord mostRecentSapOverSyrupRatio = dailySyrupProductionList.ElementAt(dailySyrupProductionList.Count()-1);
            return mostRecentSapOverSyrupRatio.syrupSapRatio;
        }

        //calc the expected next sap over syurup ratio
        public string CalcExpectedNextSapOverSyrupRatio()
        {
            return "1 : 32";
        }

        //gets the pint bottles avail
        public int GetPintBottlesAvail()
        {
            return dataBase.pintBottlesAvail;
        }

        //gets the half pint bottles avail
        public int GetHalfPintBottlesAvail()
        {
            return dataBase.halfPintBottlesAvail;
        }

        //gets the quart bottles avail
        public int GetQuartBottlesAvail()
        {
            return dataBase.quartBottlesAvail;
        }

        //sets a new value for pint bottles avail
        public void SetPintBottlesAvail(int newNum)
        {
            dataBase.UpdatePintsBottlesAvail(newNum);
        }

        //sets a new value for half pint bottles avail
        public void SetHalfPintBottlesAvail(int newNum)
        {
            dataBase.UpdateHalfPintsBottlesAvail(newNum);
        }

        //sets a new value for quart bottles avail
        public void SetQuartBottlesAvail(int newNum)
        {
            dataBase.UpdateQuartsBottlesAvail(newNum);
        }

        //gets the DailySyrupProducedList
        public ObservableCollection<DailySyrupProductionRecord> GetDailySyrupProducedList()
        {
            return dataBase.GetDailySyrupProducedList();
        }

        //gets the DailyCostList
        public ObservableCollection<DailyCostRecord> GetDailyCostList()
        {
            return dataBase.GetDailyCostList();
        }

    }
}
