using System;

namespace Aparkalekua
{
    public class Kotxea : Ibilgailua
    {
        public Kotxea(string matrikula) : base(matrikula) { }
        public override double KalkulatuOrdaina() { return (DateTime.Now - SarreraOrdua).TotalMinutes * 0.4; }
    }
}