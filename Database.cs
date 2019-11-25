using System.IO;
using System.Data.SQLite;

namespace CsvToSql
{
    class Database
    {
        public SQLiteConnection myConnection;
        public Database()
        {
            var sqlDb = @"C:\Users\xps15\source\repos\SQLite_Re\SQLite_Re\bin\Debug\database.sqlite3";
            myConnection = new SQLiteConnection($"Data Source={sqlDb}");
            if (!File.Exists(sqlDb)) 
            {
                SQLiteConnection.CreateFile(sqlDb);
            }
        }
        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
                myConnection.Open();
        }
        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
                myConnection.Close();
        }

    }
}
