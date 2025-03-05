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
    }
}