using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Disertatie
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Conexiune con = new Conexiune();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                string querry = "Select * From Login Where username = '" + txtUsername.Text + "' And password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con.DeschidereConectare());
                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;

                    Meniu form2 = new Meniu();

                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Detalii Incorecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.InchidereConectare();
            }
        }
    }
}
