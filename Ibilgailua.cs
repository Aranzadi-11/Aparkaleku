using System;

namespace Aparkalekua
{
    public abstract class Ibilgailua
    {
        protected string matrikula;
        protected DateTime sarreraOrdua;

        public Ibilgailua(string matrikula)
        {
            this.matrikula = matrikula;
            this.sarreraOrdua = DateTime.Now;
        }

        public abstract double KalkulatuOrdaina();

        public string Matrikula { get { return matrikula; } }
        public DateTime SarreraOrdua { get { return sarreraOrdua; } }
    }
}