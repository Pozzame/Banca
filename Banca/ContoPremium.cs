using System;
using System.Collections.Generic;
using System.Text;

namespace Banca
{
    class ContoPremium : Conto
    {
        decimal bonus = 2;

        public ContoPremium(int ID) : base(ID)
        {
        }

        public override bool Ritira(decimal importo)
        {
            return base.Ritira(importo - (importo / 100 * bonus));
        }

        public override void Versa(decimal importo)
        {
            base.Versa(importo + (importo / 100 * bonus));
        }


        public new string ToString()
        {
            return "ID Premium: " + ID + ", Saldo :" + saldo + ".";
        }
    }
}
