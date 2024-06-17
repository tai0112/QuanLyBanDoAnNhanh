using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Fastfood
{
    class DataConnection
    {
        string conStr;

        public DataConnection()
        {

            conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLTAN;Integrated Security=True";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(conStr);
        }

    }
}