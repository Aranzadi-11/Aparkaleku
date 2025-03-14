using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aparkalekua
{
    public partial class Form2 : Form
    {
        private List<Ibilgailua> ibilgailuak;

        public Form2(List<Ibilgailua> ibilgailuak)
        {
            InitializeComponent();
            this.ibilgailuak = ibilgailuak;
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            vehiclesListBox.Items.Clear();
            foreach (var ibilgailua in ibilgailuak)
            {
                vehiclesListBox.Items.Add(ibilgailua.Matrikula);
            }
        }

        private void OrdainduButton_Click(object sender, EventArgs e)
        {
            if (vehiclesListBox.SelectedItem != null)
            {
                var selectedVehicle = ibilgailuak.Find(v => v.Matrikula == vehiclesListBox.SelectedItem.ToString());
                var form3 = new Form3(selectedVehicle);
                form3.Show();
            }
            else
            {
                MessageBox.Show("Mesedez, hautatu ibilgailu bat.");
            }
        }

        private void IbilgailuaSartuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}