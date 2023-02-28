using Disertatie.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disertatie
{
    public partial class Meniu : Form

    {
        public Meniu()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            
            subPanelFactura.Visible = false;
            subPanelNIR.Visible = false;
            
        }

        private void hidePanel()
        {
            
            if (subPanelFactura.Visible == true)
                subPanelFactura.Visible = false;
            if (subPanelNIR.Visible == true)
                subPanelNIR.Visible = false;
            
        }

        private void showPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hidePanel();
                subPanel.Visible = true;
            }
            else
                subPanel.Visible = false;
        }

        private void Meniu_Load(object sender, EventArgs e)
        {

        }

        private void btnProdus_Click(object sender, EventArgs e)
        {
            Produs prd = new Produs();
            prd.Show();
            hidePanel();

        }

      

        private void btnFactura_Click(object sender, EventArgs e)
        {
            showPanel(subPanelFactura);
        }

        private void btnFactura1_Click(object sender, EventArgs e)
        {
            Factura fct = new Factura();
            fct.Show();
            hidePanel();
        }

        private void btnFactura2_Click(object sender, EventArgs e)
        {
            RaportFacturi fct = new RaportFacturi();
            fct.Show();
            hidePanel();
        }

        private void btnNIR_Click(object sender, EventArgs e)
        {
            showPanel(subPanelNIR);
        }

        private void btnNIR1_Click(object sender, EventArgs e)
        {
            NIR nir = new NIR();
            nir.Show();
            hidePanel();
        }

        private void btnNIR2_Click(object sender, EventArgs e)
        {
            RaportNIR rpr = new RaportNIR();
            rpr.Show();
            hidePanel();
        }

        private void btnBonTransfer_Click(object sender, EventArgs e)
        {
            BonTransfer bon = new BonTransfer();
            bon.Show();
            hidePanel();
        }

        

        private void btnInventar_Click(object sender, EventArgs e)
        {
            Inventar inv = new Inventar();
            inv.Show();

            hidePanel();
        }
    }
}
