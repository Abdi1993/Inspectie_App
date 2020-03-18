using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Inspectie_App.Model
{
    public class Floor
    {
        [PrimaryKey,AutoIncrement]
        public int FloorId { get; set; }
        public string FloorName { get; set; }
        public int Building_Id { get; set; }
    }
}
