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
using Disertatie.BLL;
using Disertatie.Dal;


namespace Disertatie
{
    public partial class Factura : MaterialSkin.Controls.MaterialForm
    {
        public Factura()
        {
            InitializeComponent();
        }

        DataTable transactionDT = new DataTable();
        ClientDal dcDAL = new ClientDal();
        ProdusBLL pl = new ProdusBLL();
        ProdusDal plDal = new ProdusDal();

        private void Factura_Load(object sender, EventArgs e)
        {
            transactionDT.Columns.Add("Nume Produs");
            transactionDT.Columns.Add("Pret");
            transactionDT.Columns.Add("Cantitate");
            transactionDT.Columns.Add("Total");
        }

           
        private void txtCauta_TextChanged_1(object sender, EventArgs e)
        {
            
            string keyword = txtCauta.Text;

            if (keyword == "")
            {
                
                txtDenumire.Text = "";
                txtEmail.Text = "";
                txtTelefon.Text = "";
                txtAdresa.Text = "";
                return;
            }

            
            ClientBLL dc = dcDAL.CautaFurnizor(keyword);

            
            txtDenumire.Text = dc.Denumire;
            txtEmail.Text = dc.Email;
            txtTelefon.Text = dc.Telefon;
            txtAdresa.Text = dc.Adresa;
        }

        private void txtCauta2_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCauta.Text;

            if (keyword == "")
            {

                txtDenumire.Text = "";
                txtEmail.Text = "";
                txtTelefon.Text = "";
                txtAdresa.Text = "";
                return;
            }


            ProdusBLL pl = plDal.CautaProdus(keyword);


            txtProdus.Text = pl.Denumire;
            txtPret.Text = pl.Pret;
            
            
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
           
            string numeProdus = txtProdus.Text;
            string Pret = txtPret.Text;
            string Cantitate = txtCantitate.Text;

            decimal Total = decimal.Parse(Pret) * decimal.Parse(Cantitate);

            decimal subTotal = decimal.Parse(txtSub.Text);
            subTotal = subTotal + Total;






            if (numeProdus == "")
            {

                MessageBox.Show("Selecteaza produsul");
            }
            else
            {

                transactionDT.Rows.Add(numeProdus, Pret, Cantitate, Total);

                
                dataGridView1.DataSource = transactionDT;
                
                txtSub.Text = subTotal.ToString();
                
                
                txtCauta2.Text = "";
                txtProdus.Text = "";

                txtPret.Text = "0.00";
                txtCantitate.Text = "0.00";
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {



            string NumeCl = txtDenumire.Text;
            string NumePR = txtProdus.Text;
            string DI = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            ClientBLL dc = dcDAL.CautaIdDupaNume(NumeCl);
            ProdusBLL pl = plDal.CautaProdusDupaNume(NumePR);

            try
            {
                if(txtDenumire.Text != "" && txtProdus.Text != "" && txtCantitate.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into Factura values('" + DI + "','" + pl.ID + "',)");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Date Salvate");
                }
                else
                {
                    MessageBox.Show("Completeaza toate campurile");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

            
    }
}


