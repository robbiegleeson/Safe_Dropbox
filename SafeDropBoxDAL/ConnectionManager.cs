using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeDropBoxDLL
{
    public class ConnectionManager
    {
        string connString = ConfigurationManager.ConnectionStrings["SafeConn"].ConnectionString;

        public string ConnectionString
        {
            get
            {
                return connString;
            }
            set
            {
                connString = value;
            }
        }

    }
}
