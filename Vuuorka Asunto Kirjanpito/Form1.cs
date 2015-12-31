using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vuuorka_Asunto_Kirjanpito.Data;


namespace Vuuorka_Asunto_Kirjanpito 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_1DATADataSet.Kohteet' table. You can move, or remove it, as needed.

            DiplayData();
        }

        private void DiplayData()
        {
            try
            {              
                KohteetDAC.GetKohteetDgv(dataGridView1);
            }
            catch (SqlException ex)
            {
                
                MessageBox.Show(ex.ToString());
           }

        }

        //void FillData()
        //{
        //    // 1
        //    // Open connection
        //    using (SqlCeConnection c = new SqlCeConnection(
        //    Properties.Settings.Default.DataConnectionString))
        //    {
        //        c.Open();
        //        // 2
        //        // Create new DataAdapter
        //        using (SqlCeDataAdapter a = new SqlCeDataAdapter(
        //            "SELECT * FROM Animals", c))
        //        {
        //            // 3
        //            // Use DataAdapter to fill DataTable
        //            DataTable t = new DataTable();
        //            a.Fill(t);
        //            // 4
        //            // Render data onto the screen
        //            dataGridView1.DataSource = t;
        //        }
        //    }
        //}
    }
}
