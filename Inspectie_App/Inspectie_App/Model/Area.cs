using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Inspectie_App.Model
{
    public class Area
    {
        [PrimaryKey, AutoIncrement]
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int Project_Id { get; set; }

        
    }
}
