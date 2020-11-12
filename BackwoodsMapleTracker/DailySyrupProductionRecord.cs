using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackwoodsMapleTracker
{
    class DailySyrupProductionRecord
    {
        public string date { get; }
        public double syrupMadePints { get; }
        public double sapUsedPints { get; }

        public string syrupSapRatio { get; }

        public DailySyrupProductionRecord(string dateValue, double syrupMadePintsValue, double sapUsedPintsValue)
        {
            date = dateValue;
            syrupMadePints = syrupMadePintsValue;
            sapUsedPints = sapUsedPintsValue;
            syrupSapRatio = getSyrupSapRatio();
        }
        public string getSyrupSapRatio()
        {
            return "1 : " + Math.Round((sapUsedPints / syrupMadePints), 1);
        }

    }
}
