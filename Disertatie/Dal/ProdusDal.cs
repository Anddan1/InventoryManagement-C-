using Disertatie.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disertatie.Dal
{
    class ProdusDal
    {
        Conexiune con = new Conexiune();
        SqlDataAdapter adp;
        DataTable dt;
        SqlCommand cmd;

        public DataTable Cauta (string CuvantCheie)
        {
            dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Produs WHERE Denumire LIKE '%" + CuvantCheie + "%' OR UnitateDeMasura LIKE '%" + CuvantCheie + "%'";

                SqlCommand cmd = new SqlCommand(sql, con.DeschidereConectare());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(dt);

               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.InchidereConectare();

            return dt;
        }

        public DataTable Select()
        {
            dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Produs";

                SqlCommand cmd = new SqlCommand(sql, con.DeschidereConectare());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adp.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.InchidereConectare();

            return dt;
        }

        public ProdusBLL CautaProdusDupaNume(string ProductName)
        {
           
            ProdusBLL p = new ProdusBLL();

            Conexiune con = new Conexiune();

            DataTable dt = new DataTable();

            try
            {
                
                string sql = "SELECT Id FROM Produs WHERE Denumire='" + ProductName + "'";
                
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con.DeschidereConectare());

                

                
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    p.ID = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.InchidereConectare();
            }

            return p;
        }

        public ProdusBLL CautaProdus(string keyword)
        {

            ProdusBLL dc = new ProdusBLL();

            DataTable dt = new DataTable();

            try
            {

                string sql = "SELECT Denumire, Pret from Produs inner join ProdusFactura on Produs.Id = ProdusFactura.Id WHERE Denumire LIKE '%" + keyword + "%'";


                SqlDataAdapter adapter = new SqlDataAdapter(sql, con.DeschidereConectare());

                adapter.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dc.Denumire = dt.Rows[0]["Denumire"].ToString();
                    dc.Pret =dt.Rows[0]["Pret"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                con.InchidereConectare();
            }

            return dc;
        }
    }

    
}
