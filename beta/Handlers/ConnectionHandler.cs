using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta.Handlers
{
    public sealed class ConnectionHandler
    {
        private static readonly ConnectionHandler instance = new ConnectionHandler();
        private static readonly object padlock = new object();
        

        static ConnectionHandler()
        {
        }

        private ConnectionHandler()
        {
        }
        public static ConnectionHandler Instance
        {
            get
            {
                return instance;
            }
        }

        public IDbConnection getConnection()
        {

            IDbConnection dbConnection = new MySqlConnection("datasource=localhost;database=NomDuBD;userid=DBLogin;password=DBPassword")
            return dbConnection;

        }


      public Boolean testConnction()
        {
            try
            {
                using (var connection =getConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }





    }
}
