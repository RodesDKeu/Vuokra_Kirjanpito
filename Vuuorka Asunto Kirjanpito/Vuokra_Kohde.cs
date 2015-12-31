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

namespace Vuuorka_Asunto_Kirjanpito
{
    public partial class Vuokra_Kohde : Form
    {
        public Vuokra_Kohde()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        //private SqlCommand cmd;
        //private SqlDataAdapter da;
        //private DataSet ds;
        //private DataTable dt;
        private string connetionString = null;

        private void SetConn()
        {
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=e:\Users\Lasse\Documents\Visual Studio 2013\Projects\Vuuorka Asunto Kirjanpito\Vuuorka Asunto Kirjanpito\1DATA.mdf;Integrated Security=True;connect Timeout=30";
            conn = new SqlConnection(connetionString);
        }
        //private string sql = null;
        ////
        ////SqlCommand  -> insert, Update, delete 
        ////SqlDataReader -> Select
        ////SqlDataAdapter  <-> Select, insert, Update, delete





        //void Display()
        //{
        //    try
        //    {
        //        SetConn();

        //        SqlDataAdapter sda = new SqlDataAdapter("Select * from Kohteet", conn);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //        dataGridView2.Rows.Clear();
        //        foreach (DataRow item in dt.Rows)
        //        {
        //            int n = dataGridView2.Rows.Add();
        //            dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
        //            dataGridView2.Rows[n].Cells[1].Value = item[7].ToString();
        //            dataGridView2.Rows[n].Cells[2].Value = item[1].ToString();
        //            dataGridView2.Rows[n].Cells[3].Value = item[2].ToString();
        //            dataGridView2.Rows[n].Cells[4].Value = item[3].ToString();
        //            dataGridView2.Rows[n].Cells[5].Value = item[4].ToString();
        //            dataGridView2.Rows[n].Cells[6].Value = item[5].ToString();
        //            dataGridView2.Rows[n].Cells[7].Value = item[6].ToString();

        //        }
        //    }
        //    catch (SqlException ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }
            

        //}

   

        private void btnUusi_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
            textBox7.Text = ""; textBox8.Text = "";
            //Display();
        }

        private void btnTallenna_Click_1(object sender, EventArgs e)
        {
            try
            {
                SetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Kohteet
            ( VuokralainenID, Taloyhtiö, Osoite, Isännöitsiä, Vuokra, Vesimaksu, MuuMaksu)
            VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text +
                           "',            '" + textBox8.Text +  "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tiedot tallennettu!");
                //Display();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Virhe! \n " + ex.ToString());
            }
        }

        private void btnPoista_Click_1(object sender, EventArgs e)
        {
            try
            {
                SetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE FROM Kohteet
            WHERE (KohdeID = '" + textBox1.Text + "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tiedot Poistettu!");
                //Display();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Virhe! \n " + ex.ToString());
            }
        }

        private void btnPaivita_Click_1(object sender, EventArgs e)
        {
            try
            {
                SetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Kohteet
                SET VuokralainenID ='" + textBox2.Text +
                                "', Taloyhtiö ='" + textBox3.Text +
                                "', Osoite ='" + textBox4.Text +
                                "', Isännöitsiä ='" + textBox5.Text +
                                "', Vuokra ='" + textBox6.Text +
                                "', Vesimaksu ='" + textBox7.Text +
                                "', MuuMaksu ='" + textBox8.Text + 
                "' WHERE (KohdeID ='" + textBox1.Text + "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tiedot Päivitetty");
                //Display();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Virhe! \n " + ex.ToString());
            }
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void Kohde_Load(object sender, EventArgs e)
        {
            //Display();
        }

    }
}
