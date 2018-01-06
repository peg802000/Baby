using System;
using SQLite;
namespace BabyApp
{
    public class DatabaseHelper
    {
        private string _path;
        private SQLiteConnection _db;
        public DatabaseHelper()
        {
            //_path = path;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            _db = new SQLiteConnection(System.IO.Path.Combine(folder, "babyapp.db"));
           // _db = new SQLiteConnection(path);

        }

        public void CreateTable()
        {
            _db.CreateTable<BreastfeedingLog>();
        }
        public void InsertBreastfeedingLog(BreastfeedingLog bl)
        {
            _db.Insert(bl);
        }
        public void Select()
        {
            var tableList = _db.Table<BreastfeedingLog>();
            foreach (var s in tableList)
            {
                string v = s.Side;
            }
        }
          
    }
}
