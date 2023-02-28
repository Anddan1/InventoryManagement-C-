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
    public partial class BonTransfer : MaterialSkin.Controls.MaterialForm
    {
        Conexiune con = new Conexiune();
        SqlDataAdapter adp;
        DataTable dt;

        ProdusDal pdal = new ProdusDal();

        public BonTransfer()
        {
            InitializeComponent();
        }

        private void BonTransfer_Load(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDenumire.Text != "" && txtCantitate.Text != "" && txtMagV.Text !="" && txtMagN.Text != "" && txtNumar.Text != "")
                {
                    SqlCommand cmd1 = new SqlCommand("insert into ProdusTransfer values('"+txtNumar.Text+ "','" + pdal.CautaProdusDupaNume(txtDenumire.Text) + "','" + txtCantitate.Text + "')", con.DeschidereConectare());
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost salvate");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
