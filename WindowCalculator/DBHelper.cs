using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WindowCalculator
{
    public class DBHelper
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=WindowCalculatorDB; Integrated Security=true";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
