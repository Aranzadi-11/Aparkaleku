using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aparkalekua
{
    public partial class Form1 : Form
    {
        private List<Ibilgailua> ibilgailuak;

        public Form1()
        {
            InitializeComponent();
            ibilgailuak = new List<Ibilgailua>();
            AddDefaultVehicles();
        }

        private void AddDefaultVehicles()
        {
            var kotxea1 = new Kotxea("AAA1111")
            {
                SarreraOrdua = new DateTime(2025, 3, 1, 8, 30, 0)
            };
            ibilgailuak.Add(kotxea1);

            var kotxea2 = new Kotxea("BBB2222")
            {
                SarreraOrdua = new DateTime(2025, 3, 2, 9, 0, 0)
            };
            ibilgailuak.Add(kotxea2);

            var furgoneta = new Furgoneta("CCC3333", 5.5)
            {
                SarreraOrdua = new DateTime(2025, 3, 3, 10, 15, 0)
            };
            ibilgailuak.Add(furgoneta);

            var autobusa = new Autobusa("DDD4444", 40)
            {
                SarreraOrdua = new DateTime(2025, 3, 4, 11, 45, 0)
            };
            ibilgailuak.Add(autobusa);
        }

        private void GehituIbilgailua(string matrikula, string mota, double luzera = 0, int eserlekuKop = 0)
        {
            Ibilgailua ibilgailua;
            switch (mota)
            {
                case "Kotxea":
                    ibilgailua = new Kotxea(matrikula);
                    break;
                case "Furgoneta":
                    ibilgailua = new Furgoneta(matrikula, luzera);
                    break;
                case "Autobusa":
                    ibilgailua = new Autobusa(matrikula, eserlekuKop);
                    break;
                default:
                    MessageBox.Show("Ibilgailu mota ezezaguna");
                    return;
            }
            ibilgailuak.Add(ibilgailua);
            MessageBox.Show($"{mota} gehitua: {matrikula}");
        }

        private void MotaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMota = motaComboBox.SelectedItem.ToString();
            luzeraLabel.Visible = selectedMota == "Furgoneta";
            luzeraTextBox.Visible = selectedMota == "Furgoneta";
            eserlekuKopLabel.Visible = selectedMota == "Autobusa";
            eserlekuKopTextBox.Visible = selectedMota == "Autobusa";
        }

        private void GehituButton_Click(object sender, EventArgs e)
        {
            string matrikula = matrikulaTextBox.Text;
            string mota = motaComboBox.SelectedItem?.ToString();
            double luzera = 0;
            int eserlekuKop = 0;

            if (mota == "Furgoneta" && !double.TryParse(luzeraTextBox.Text, out luzera))
            {
                MessageBox.Show("Mesedez, sartu luzera baliozko bat.");
                return;
            }

            if (mota == "Autobusa" && !int.TryParse(eserlekuKopTextBox.Text, out eserlekuKop))
            {
                MessageBox.Show("Mesedez, sartu eserleku kopuru baliozko bat.");
                return;
            }

            GehituIbilgailua(matrikula, mota, luzera, eserlekuKop);
        }

        private void IbilgailuaAteraButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(ibilgailuak);
            form2.Show();
        }
    }
}