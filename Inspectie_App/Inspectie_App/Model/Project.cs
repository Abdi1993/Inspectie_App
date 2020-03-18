using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Inspectie_App.Model
{
    public class Project
    {
        [PrimaryKey, AutoIncrement]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
