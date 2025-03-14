using System;

namespace Aparkalekua
{
    public class Autobusa : Ibilgailua
    {
        private int eserlekuKop;

        public Autobusa(string matrikula, int eserlekuKop) : base(matrikula)
        {
            this.eserlekuKop = eserlekuKop;
        }

        public override double KalkulatuOrdaina()
        {
            return (DateTime.Now - SarreraOrdua).TotalMinutes * 0.4 + eserlekuKop * 0.25;
        }

        public int EserlekuKop
        {
            get { return eserlekuKop; }
            set { eserlekuKop = value; }
        }
    }
}