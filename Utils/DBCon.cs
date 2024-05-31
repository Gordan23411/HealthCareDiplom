using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus.Utils
{
    internal class DBCon
    {
        private SqlConnection sqlCon = new SqlConnection(
            "Data Source= WIN-1CEMG7V4H4D\\SQLEXPRESS;Initial Catalog=Healthcareplus;Integrated Security=True"
        );
        public SqlConnection SqlConnection
        {
            get { return sqlCon; }
        }
    }
}
