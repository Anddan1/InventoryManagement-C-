using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disertatie.Dal;

namespace Disertatie
{
    public partial class Produs : MaterialSkin.Controls.MaterialForm

    {
        Conexiune con = new Conexiune();
        SqlDataAdapter adp;
        DataTable dt;
        SqlCommand cmd;
        public static int produsId;

        public Produs()
        {
            InitializeComponent();
        }

        ProdusDal pdal = new ProdusDal();

        private void Produs_Load(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("Select Id, Denumire, UnitateDeMasura, Descriere From Produs", con.DeschidereConectare());

            dt = new DataTable();
            adp.Fill(dt);
            grdProd.DataSource = dt;

            con.InchidereConectare();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDenumire.Text != "" && txtUM.Text != "" && txtDescriere.Text != "")
                {
                    cmd = new SqlCommand("insert into Produs values('" + txtDenumire.Text + "', '" + txtUM.Text + "', '" + txtDescriere.Text + "')", con.DeschidereConectare());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Datele au fost salvate");
                }
                else
                {
                    MessageBox.Show("Completeaza toate campurile");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.InchidereConectare();
            Clear();
        }

        public void Clear()
        {
            txtDenumire.Text = "";
            txtDescriere.Text = "";
            txtUM.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Keywordss from Form
            string CuvinteCheie = txtCautare.Text;

            if (CuvinteCheie != null)
            {
                //Search the products
                DataTable dt = pdal.Cauta(CuvinteCheie);
                grdProd.DataSource = dt;
            }
            else
            {
                //Display All the products
                DataTable dt = pdal.Select();
                grdProd.DataSource = dt;
            }
        }

        private void grdProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            produsId = Convert.ToInt32(grdProd.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtDenumire.Text = (grdProd.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtUM.Text = (grdProd.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtDescriere.Text = (grdProd.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDenumire.Text != "" && txtUM.Text != "" && txtDescriere.Text != "")
                {
                    cmd = new SqlCommand("update Produs set Denumire='" + txtDenumire.Text + "', UnitateDeMasura='" + txtUM.Text + "', Descriere='" + txtDescriere.Text + "' where Id='"+produsId+"'", con.DeschidereConectare());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Datele au fost salvate");
                }
                else
                {
                    MessageBox.Show("Completeaza toate campurile");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.InchidereConectare();
            Clear();
        }
    }
}
