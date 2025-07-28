using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MauiAppFit.Models;

namespace MauiAPP3BIMESTRE.Helper
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _db;
        public SQliteDataBaseHelper(string dbPath) 
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Atividade>().Wait();
        }
    }
}
