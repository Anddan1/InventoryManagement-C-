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
    class FurnizorDALL
    {
        Conexiune con = new Conexiune();

        public FurnizorBLL CautaFurnizor(string keyword)
        {

            FurnizorBLL dc = new FurnizorBLL();

            DataTable dt = new DataTable();

            try
            {

                string sql = "SELECT Denumire, Email, Telefon, Adresa from Furnizor WHERE Id LIKE '%" + keyword + "%' OR Denumire LIKE '%" + keyword + "%'";


                SqlDataAdapter adapter = new SqlDataAdapter(sql, con.DeschidereConectare());

                adapter.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dc.Denumire = dt.Rows[0]["Denumire"].ToString();
                    dc.Email = dt.Rows[0]["Email"].ToString();
                    dc.Telefon = dt.Rows[0]["Telefon"].ToString();
                    dc.Adresa = dt.Rows[0]["Adresa"].ToString();
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

            return dc;
        }

        public FurnizorBLL CautaIdDupaNume(string Nume)
        {

            FurnizorBLL dc = new FurnizorBLL();

            Conexiune con = new Conexiune();
            DataTable dt = new DataTable();

            try
            {

                string sql = "SELECT Id FROM Furnizor WHERE Denumire='" + Nume + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con.DeschidereConectare());




                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    dc.Id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return dc;
        }
    }
}
