using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Login
{
    /// <summary>
    /// define the login eventhandler delegate. You will use this event to track employee logins to your application.
    /// </summary>
    /// <param name="loginName">Username(string)</param>
    /// <param name="status">bool</param>
    public delegate void LoginEventHandler(string loginName, Boolean status);

    class Employee//could be same as delegate...
    {
        /// <summary>
        /// define the LoginEvent as the delegate type.
        /// </summary>
        public event LoginEventHandler LoginEvent;
        /// <summary>
        /// raise the LoginEvent.
        /// </summary>
        /// <param name="loginName">String</param>
        /// <param name="password">String</param>
        public void Login(string loginName, string password)
        {
            //Data normally retrieved from database.
            if (loginName == "Smith" && password == "js")
            {
                LoginEvent(loginName, true);
            }
            else
            {
                LoginEvent(loginName, false);
            }
        }
    }
}
