using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Inspectie_App;

namespace Inspectie_App.Helper
{
    public class Constants
    {
        public static SQLiteConnection cxn = new SQLiteConnection(App.databaseLoaction);
    }
}
