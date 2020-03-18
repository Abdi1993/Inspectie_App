using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Inspectie_App.Model
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public int Area_Id { get; set; }
    }
}
