using System;
using System.Collections.Generic;
using System.Text;

namespace Banca
{
    class ContoPremium : Conto
    {
        public static decimal Bonus { get; set; }

        public ContoPremium(int ID) : base(ID)
        {
        }

        public override bool Ritira(decimal importo)
        {
            return base.Ritira(importo - (importo / 100 * Bonus));
        }

        public override void Versa(decimal importo)
        {
            base.Versa(importo + (importo / 100 * Bonus));
        }

        public new string ToString()
        {
            return "ID Premium: " + ID + ", Saldo :" + saldo + ".";
        }
    }
}
