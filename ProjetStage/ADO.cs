using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetStage
{
    class ADO
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public void connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "Data Source=DESKTOP-ELPBKRT\\SQLEXPRESS;Initial Catalog=Gestion des personnels;Integrated Security=True";
                con.Open();
            }

        }
    }
}
