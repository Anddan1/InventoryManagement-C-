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

namespace Disertatie.UI
{
    public partial class Inventar : MaterialSkin.Controls.MaterialForm
    {
        Conexiune con = new Conexiune();
        SqlDataAdapter adp;
        DataTable dt;

        public Inventar()
        {
            InitializeComponent();
        }

        private void Inventar_Load(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("Select Produs.Id, Produs.Denumire, Produs.UnitateDeMasura, Produs.Descriere,((CantitateReceptie + ProdusMagazie.Cantitate)-ProdusFactura.Cantitate) as CantitateTotala from ReceptieProdus inner join Produs on produs.Id= ReceptieProdus.Id inner join ProdusMagazie on Produs.Id = ProdusMagazie.IdProd inner join ProdusFactura on Produs.Id =ProdusFactura.Id Group By Produs.Id, Produs.Denumire, Produs.UnitateDeMasura, Produs.Descriere, ((CantitateReceptie + ProdusMagazie.Cantitate)-ProdusFactura.Cantitate)", con.DeschidereConectare());

            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            con.InchidereConectare();

        }
    }
}
