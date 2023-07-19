using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Taotranon_ny_Nosy.database
{
    internal class BaseChantier
    {
        private static string getConnectionString()
        {
            return "Data Source=P15A-02-DIAMOND\\SQLEXPRESS;Initial Catalog=tnDatabase;Integrated Security=True";
        }

        public void enregistrerChant()
        {
            
        }
    }
}
