using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Vuuorka_Asunto_Kirjanpito.Data
{
    class KohteetDAC
    {
        public static string sql = "SELECT * FROM Kohteet";
        public static SqlDataReader GetKohteetReader()
        {
            SqlDataReader reader;

            using (SqlCommand command = new SqlCommand(sql, ConnectionManager.GetConnection()))
            {
                reader = command.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection);
            }

            return reader;
        }

        public static DataGridView GetKohteetDgv(DataGridView Dgv)
        {

            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, ConnectionManager.GetConnection()))
            {
                DataTable table = new DataTable();
                sqlAdapter.Fill(table);
                DataGridView dgv;
                dgv = Dgv;
                dgv.DataSource = table;
                dgv.Columns[0].HeaderText = "aa";
                return dgv;
            }



        }
    }
}

