using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disertatie.BLL;
using Disertatie.Dal;
using System.Data.SqlClient;

namespace Disertatie
{
    public partial class NIR : MaterialSkin.Controls.MaterialForm
    {
        public NIR()
        {
            InitializeComponent();
        }

        DataTable transactionDT = new DataTable();
        FurnizorDALL dcDAL = new FurnizorDALL();
        ProdusBLL pl = new ProdusBLL();
        ProdusDal plDal = new ProdusDal();

        private void NIR_Load(object sender, EventArgs e)
        {
            transactionDT.Columns.Add("Nume Produs");
            transactionDT.Columns.Add("Pret");
            transactionDT.Columns.Add("Cantitate");
            transactionDT.Columns.Add("Total");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string numeProdus = txtProdus.Text;
            string Pret = txtPret.Text;
            string Cantitate = txtCantitate.Text;

            decimal Total = decimal.Parse(Pret) * decimal.Parse(Cantitate);

            decimal subTotal = decimal.Parse(txtSuma.Text);
            subTotal = subTotal + Total;






            if (numeProdus == "")
            {

                MessageBox.Show("Selecteaza produsul");
            }
            else
            {

                transactionDT.Rows.Add(numeProdus, Pret, Cantitate, Total);


                dataGridView1.DataSource = transactionDT;

                txtSuma.Text = subTotal.ToString();


                
                txtProdus.Text = "";

                txtPret.Text = "0.00";
                txtCantitate.Text = "0.00";
            }
        }
    }
}
