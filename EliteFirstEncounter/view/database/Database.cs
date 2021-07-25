using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteFirstEncounter.view.database
{
    class Database
    {
        protected static SqliteConnection connector;

        protected static void Connect()
        {
            connector = new("Data Source=.\\Resources\\database.db");
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_winsqlite3());
        }
    }
}
