using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vuuorka_Asunto_Kirjanpito
{
    class DataTest
    {
        public void SaveInfo()
        {
            try
            {
                DataUpdate("Data has been updated");
            }
            catch
            {
                DataUpdate("Data could not be updated");
            }
        }
        public MDIMain.DataUpdateEventHandler DataUpdate { get; set; }
    }
}
