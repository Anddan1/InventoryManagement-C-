using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Disertatie
{
    class Conexiune
    {
        SqlConnection con;

        public Conexiune()
        {
            con = new SqlConnection("Data Source=DESKTOP-BNDJGQB; Initial Catalog=Disertatie; Integrated Security=True");
        }

        public SqlConnection DeschidereConectare()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {

            }

            return con;
        }

        public void InchidereConectare()
        {
            try
            {
                con.Close();
            }
            catch(Exception)
            {

            }
        }
    }
}
