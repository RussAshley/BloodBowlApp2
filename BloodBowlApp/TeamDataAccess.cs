using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBowlApp
{
    class TeamDataAccess
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public TeamDataAccess (string connectionString)
        {
            ConnectionString = connectionString;
        }
    }

}
