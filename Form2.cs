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
                form3.FormClosed += (s, args) => this.Close(); // Cierra este formulario cuando el nuevo se cierre
                form3.Show();
                this.Hide(); // Oculta este formulario
            }
            else
            {
                MessageBox.Show("Mesedez, hautatu ibilgailu bat.");
            }
        }

        private void IbilgailuaSartuButton_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            this.Close(); // Cierra Form2 al volver a Form1
        }
    }
}