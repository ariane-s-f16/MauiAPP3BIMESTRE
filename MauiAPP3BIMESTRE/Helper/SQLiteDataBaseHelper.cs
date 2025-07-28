using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MauiAPP3BIMESTRE.Models;

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
        public Task<Atividade> GetbyId(int id) 
        {
            return _db.Table<Atividade>().FirstAsync(i=i=>i.Id == id);
        }
        public Task<int> Insert(int id)
        {
            return _db.InsertAsync(model);
        }
    }
}
