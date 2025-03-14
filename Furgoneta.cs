using System;

namespace Aparkalekua
{
    public class Furgoneta : Ibilgailua
    {
        private double luzera;

        public Furgoneta(string matrikula, double luzera) : base(matrikula)
        {
            this.luzera = luzera;
        }

        public override double KalkulatuOrdaina()
        {
            return (DateTime.Now - SarreraOrdua).TotalMinutes * 0.4 + luzera * 0.2;
        }

        public double Luzera
        {
            get { return luzera; }
            set { luzera = value; }
        }
    }
}