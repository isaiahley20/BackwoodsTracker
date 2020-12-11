using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MongoDB.Driver;
using MongoDB.Bson;

namespace BackwoodsMapleTracker
{
    class Database
    {
        public Database()
        {
            LoadDailySyrupProducedList();
            LoadDailyCostList();
            LoadJarsAvail();
            
            var dbClient = new MongoClient("mongodb+srv://IsaiahLey:password@maple_tracker.kk6ey.mongodb.net/maple_tracker?retryWrites=true&w=majority");

            var database = dbClient.GetDatabase("maple_tracker");
            var dailyCostRecords = database.GetCollection<BsonDocument>("daily_cost_records");
            var dailySyrupProductionRecords = database.GetCollection<BsonDocument>("daily_syrup_production_records");


            var doc = dailyCostRecords.Find(new BsonDocument()).ToList();
            /*
            foreach (BsonDocument docu in doc)
            {
                Console.WriteLine(docu.ToString());
            }
            */
            /*
            var dailySyrupProductionRecordDoc = new BsonDocument
            {
                {"date", "12/01/2020"},
                {"syrupMadePints", 10},
                {"sapUsedPints", 400}
            };

            var dailyCostRecordDoc = new BsonDocument
            {
                {"date", "12/01/2020"},
                {"name", "Jars"},
                {"cost", 100}
            };

            dailySyrupProductionRecords.InsertOne(dailySyrupProductionRecordDoc);
            dailyCostRecords.InsertOne(dailyCostRecordDoc);
            */
        }

        public int pintBottlesAvail { get; set; }
        public int halfPintBottlesAvail { get; set; }
        public int quartBottlesAvail { get; set; }
        public ObservableCollection<DailySyrupProductionRecord> dailySyrupProducedList = new ObservableCollection<DailySyrupProductionRecord>();
        public ObservableCollection<DailyCostRecord> dailyCostList = new ObservableCollection<DailyCostRecord>();

        public void LoadDailySyrupProducedList()
        {
            if(dailySyrupProducedList.Count() == 0)
            {
                dailySyrupProducedList.Add(new DailySyrupProductionRecord("10/10/2020", 1, 28));
                dailySyrupProducedList.Add(new DailySyrupProductionRecord("10/12/2020", 2, 29));
                dailySyrupProducedList.Add(new DailySyrupProductionRecord("10/13/2020", 2, 30));
            }
        }
        public void LoadDailyCostList()
        {
            if (dailyCostList.Count() == 0)
            {
                dailyCostList.Add(new DailyCostRecord("10/14/2020", "Liquid Propane", 150.57));
                dailyCostList.Add(new DailyCostRecord("10/15/2020", "Jars", 32.78));
                dailyCostList.Add(new DailyCostRecord("10/16/2020", "Cleaning Supplies", 47.82));
            }
        }

        public void LoadJarsAvail()
        {
            pintBottlesAvail = 25;
            halfPintBottlesAvail = 5;
            quartBottlesAvail = 10;
        }

        public void UpdatePintsBottlesAvail(int pintsAvail)
        {
            pintBottlesAvail = pintsAvail;
        }

        public void UpdateHalfPintsBottlesAvail(int halfPintsAvail)
        {
            halfPintBottlesAvail = halfPintsAvail;
        }

        public void UpdateQuartsBottlesAvail(int quartsAvail)
        {
            quartBottlesAvail = quartsAvail;
        }

        public ObservableCollection<DailySyrupProductionRecord> GetDailySyrupProducedList()
        {
            return dailySyrupProducedList;
        }

        public ObservableCollection<DailyCostRecord> GetDailyCostList()
        {
            return dailyCostList;
        }

    }
}
