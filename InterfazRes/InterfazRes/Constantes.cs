using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfazRes
{
    public static class Constantes
    {
        private const string DatabaseFileName = "SQLite.db3";
        public const SQLite.SQLiteOpenFlags flags = SQLite.SQLiteOpenFlags.ReadWrite | SQLite.SQLiteOpenFlags.Create | 
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                return Path.Combine(basePath, DatabaseFileName);
            
            }
        }
    }

}
