using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MongoDB.Driver;
using MongoDB.Bson;

using System.Windows;

namespace BackwoodsMapleTracker
{
    class Database
    {
        MongoClient dbClient;
        IMongoDatabase database;
        public Database()
        {
            //establishes connection to MongoClient and mapletracker cluster
            dbClient = new MongoClient("mongodb+srv://IsaiahLey:fakepassword04271999@mapletracker.kk6ey.mongodb.net/maple_tracker?retryWrites=true&w=majority");
            //connects to the maple_tracker database inside mapletracker cluster
            database = dbClient.GetDatabase("maple_tracker");
            LoadDailySyrupProducedList();
            LoadDailyCostList();
            LoadJarsAvail();

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
            dailySyrupProducedList.Clear();
            //gets the collection daily_syrup_production_records from the database
            var dailySyrupProductionRecordsCollection = database.GetCollection<BsonDocument>("daily_syrup_production_records");
            //gets the BsonDocuments from the collection
            var allDailySyrupProductionRecords = dailySyrupProductionRecordsCollection.Find(new BsonDocument()).ToList();
            //used to split up the BsonDocument
            char[] delimiterChars = { ':', ',', '}' };
            //puts the values of the DailyCostRecord into the list of them
            foreach (BsonDocument dailySyrupProductionRecord in allDailySyrupProductionRecords)
            {
                string[] splitString = dailySyrupProductionRecord.ToString().Split(delimiterChars);
                string newDate = (splitString[4].ToString().Replace("\"", ""));
                double newSyrupMadePints = double.Parse(splitString[6].ToString());
                double newSapUsedPints = double.Parse(splitString[8].ToString());
                dailySyrupProducedList.Add(new DailySyrupProductionRecord(newDate, newSyrupMadePints, newSapUsedPints));
            }
        }
        public void LoadDailyCostList()
        {
            dailyCostList.Clear();
            //gets the collection daily_cost_records from the database
            var dailyCostRecordsCollection = database.GetCollection<BsonDocument>("daily_cost_records");
            //gets the BsonDocuments from the collection
            var dailyCostRecordsAll = dailyCostRecordsCollection.Find(new BsonDocument()).ToList();
            //used to split up the BsonDocument
            char[] delimiterChars = { ':', ',', '}' };
            //puts the values of the DailyCostRecord into the list of them
            foreach (BsonDocument value in dailyCostRecordsAll)
            {
                string[] splitString = value.ToString().Split(delimiterChars);
                string newName = (splitString[4].ToString().Replace("\"", ""));
                string newDate = (splitString[6].ToString().Replace("\"", ""));
                double newCost = double.Parse(splitString[8].ToString());
                dailyCostList.Add(new DailyCostRecord(newDate, newName, newCost));
            }
        }

        public void LoadJarsAvail()
        {
            //gets the collection inventory_available from the database
            var inventoryCollection = database.GetCollection<BsonDocument>("inventory_available");
            //gets the BsonDocuments from the collection
            var allInventory = inventoryCollection.Find(new BsonDocument()).FirstOrDefault();
            //used to split up the BsonDocument
            char[] delimiterChars = { ':', ',', '}' };
            string[] splitString = allInventory.ToString().Split(delimiterChars);
            pintBottlesAvail = int.Parse(splitString[3]);
            halfPintBottlesAvail = int.Parse(splitString[5]);
            quartBottlesAvail = int.Parse(splitString[7]);
        }

        public void UpdatePintsBottlesAvail(int pintsAvail)
        {
            //change to update Database
            pintBottlesAvail = pintsAvail;
        }

        public void UpdateHalfPintsBottlesAvail(int halfPintsAvail)
        {
            //change to update Database
            halfPintBottlesAvail = halfPintsAvail;
        }

        public void UpdateQuartsBottlesAvail(int quartsAvail)
        {
            //change to update Database
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
