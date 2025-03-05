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
        public DateTime SarreraOrdua
        {
            get { return sarreraOrdua; }
            set { sarreraOrdua = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Ibilgailua other = (Ibilgailua)obj;
            return this.matrikula == other.matrikula;
        }

        public override int GetHashCode() => matrikula.GetHashCode();
    }
}