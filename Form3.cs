using System;
using System.Collections.Generic;
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
            matrikulaLabel.Text = $"Matrikula: {ibilgailua.Matrikula}";
            sarreraOrduaLabel.Text = $"Sarrera ordua: {ibilgailua.SarreraOrdua}";
            ordainduOrduaLabel.Text = $"Ordaindu ordua: {DateTime.Now}";

            double precio = ibilgailua.KalkulatuOrdaina();

            if (ibilgailua is Furgoneta furgoneta)
            {
                luzeraLabel.Text = $"Luzera: {furgoneta.Luzera}";
                luzeraLabel.Visible = true;
            }
            else if (ibilgailua is Autobusa autobusa)
            {
                eserlekuKopLabel.Text = $"Eserleku kopurua: {autobusa.EserlekuKop}";
                eserlekuKopLabel.Visible = true;
            }

            precioLabel.Text = $"Precio a pagar: {precio:0.00}€";
            precioLabel.Visible = true;
        }

        private void OrdainduButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordainketa egin da. Eskerrik asko!");
            Application.Exit();
        }

        private void ItzuliButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(new List<Ibilgailua>()); // Pasa la lista adecuada aquí
            form2.Show();
            this.Close(); // Cierra Form3 al volver a Form2
        }
    }
}