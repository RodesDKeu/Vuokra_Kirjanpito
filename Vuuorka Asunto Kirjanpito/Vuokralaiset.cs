using System;
using System.IO;
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
    public partial class Vuokralaiset : Form
    {


        //1                      //KohdeID               
        //2                     //VuokralainenNimi      
        //3                    //Puhelin               
        //4                   //Puhelin_2             
        //5                  //Email                 
        //6                 //Pankki                
        //7                //PankkiTili                                
        //8               //Muuta        
        //9              //VuokralainenID             

        public Vuokralaiset()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }
        private SqlConnection conn;
        //private SqlCommand cmd;
        //private SqlDataAdapter da;
        //private DataSet ds;
        //private DataTable dt;
        private string connetionString = null;
        private void SetConn()
        {
            string path;
            path = @"e:\Users\Lasse\Documents\Visual Studio 2013\Projects\Vuuorka Asunto Kirjanpito\Vuuorka Asunto Kirjanpito\Data\1DATA.mdf";
            //path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Data\1DATA.mdf";
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + path + ";Integrated Security=True;connect Timeout=30";
            conn = new SqlConnection(connetionString);
        }
        //private string sql = null;
        ////
        ////SqlCommand  -> insert, Update, delete 
        ////SqlDataReader -> Select
        ////SqlDataAdapter  <-> Select, insert, Update, delete


        private void btnUusi_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
            textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = "";
            Display();
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try
            {
                SetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Vuokralaiset
            ( KohdeID, VuokralainenNimi, Puhelin, Email, Pankki, PankkiTili, Puhelin_2, Muuta)
            VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text +
                           "',            '" + textBox8.Text + "','" + textBox9.Text + "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tiedot tallennettu!");
                Display();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Virhe! \n " + ex.ToString());
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                SetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE FROM Vuokralaiset
            WHERE (VuokralainenID = '" + textBox1.Text + "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tiedot Poistettu!");
                Display();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Virhe! \n " + ex.ToString());
            }
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            try
            {
                SetConn();
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Vuokralaiset
                SET KohdeID ='" + textBox2.Text +
                                "', VuokralainenNimi ='" + textBox3.Text +
                                "', Puhelin ='" + textBox4.Text +
                                "', Email ='" + textBox5.Text +
                                "', Pankki ='" + textBox6.Text +
                                "', PankkiTili ='" + textBox7.Text +
                                "', Puhelin_2 ='" + textBox8.Text +
                                "', Muuta ='" + textBox9.Text +
                "' WHERE (VuokralainenID ='" + textBox1.Text + "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tiedot Päivitetty");
                Display();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Virhe! \n " + ex.ToString());
            }
        }




        void Display()
        {
            SetConn();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Vuokralaiset", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[8].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[7].ToString();

            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vuokra_Kohde kohde = new Vuokra_Kohde();
            this.AddOwnedForm(kohde);
            kohde.Show();
        }


    }
}
