using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Vuuorka_Asunto_Kirjanpito.Data
{
    class ConnectionManager
    {
       
        /// <summary>
        /// Remember to .close() connection after use! 
        /// </summary>
        /// <returns>(SqlConnection) connection</returns>
        public static SqlConnection GetConnection()
        {
            
            const string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=e:\Users\Lasse\Documents\Visual Studio 2013\Git\Vuokra_Kirjanpito\WindowsFormsControlLibrary2\Resources\_UserDB.mdf;Integrated Security=True";
            //path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Data\1DATA.mdf";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

    }
}

