using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary2
{
    public partial class ctlLogin: UserControl
    {
        public ctlLogin()
        {
            InitializeComponent();
        }
        #region MyRegion

        //private string userName = "";
        //private string passWord="";
        //private bool loginStatus=false;
        //private int loginTries = 0;

        /// <summary>
        /// UserName
        /// </summary>
        //public string UserName
        //{

        //    //string pass = txtPassword.Text;   
        //    get 
        //    {                
        //        return userName;
        //    }
        //    set 
        //    {
        //        userName = txtUser.Text;
        //    }
        //}

        ///// <summary>
        ///// PassWord
        ///// </summary>
        //public string PassWord
        //{
        //    get
        //    {
        //        return passWord;
        //    }
        //    set
        //    {
        //        passWord = txtPassword.Text;
        //    }
        //}
        
        #endregion



        private void ctlLogin_Load(object sender, EventArgs e)
        {
            //ctlLogin.s
        }

        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        void oEmployee_LoginEvent(string loginName, bool status)
        {
            MessageBox.Show("Login status :" + status);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginEventClass eLogin = new LoginEventClass();
            eLogin.LoginEvent += new LoginEventHandler(oEmployee_LoginEvent);
            eLogin.Login(txtUser.Text, txtPassword.Text);
        }
    }
}
