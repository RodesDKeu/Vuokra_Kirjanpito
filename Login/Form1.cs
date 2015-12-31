using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gets called when the Employee class issues a LoginEvent.
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="status"></param>
        void oEmployee_LoginEvent(string loginName, bool status)
        {
            MessageBox.Show("Login status :" + status);
        }

        /// <summary>
        ///wire up the Employee class’s LoginEvent with an eventhandler in the form class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee();
            oEmployee.LoginEvent += new LoginEventHandler(oEmployee_LoginEvent);
            oEmployee.Login(textBox1.Text, textBox2.Text);
        }
    }
}
