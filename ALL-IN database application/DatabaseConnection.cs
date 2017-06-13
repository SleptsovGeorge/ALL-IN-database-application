using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_IN_database_application
{

    class DatabaseConnection
    {
        protected MySqlConnection connect; 

        public DatabaseConnection()
        {
            connect = new MySqlConnection("Server=localhost;Database=lanparty;Uid=root;Pwd=flikker24");
        }
    }
}
