using System;
using System.Windows.Forms;

namespace Aparkalekua
{
    public partial class Form3 : Form
    {
        private Ibilgailua ibilgailua;

        public Form3(Ibilgailua ibilgailua)
        {
            InitializeComponent();
            this.ibilgailua = ibilgailua;
            LoadVehicleDetails();
        }

        private void LoadVehicleDetails()
        {
            matrikulaLabel.Text = ibilgailua.Matrikula;
            sarreraOrduaLabel.Text = ibilgailua.SarreraOrdua.ToString();
            ordainduOrduaLabel.Text = DateTime.Now.ToString();

            if (ibilgailua is Furgoneta furgoneta)
            {
                luzeraLabel.Text = furgoneta.Luzera.ToString();
                luzeraLabel.Visible = true;
            }
            else if (ibilgailua is Autobusa autobusa)
            {
                eserlekuKopLabel.Text = autobusa.EserlekuKop.ToString();
                eserlekuKopLabel.Visible = true;
            }
        }

        private void OrdainduButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordainketa egin da. Eskerrik asko!");
            Application.Exit();
        }

        private void ItzuliButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}