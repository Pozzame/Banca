using System;
using System.Collections.Generic;
using System.Text;

namespace Banca
{
    class ContoIta : Conto
    {
        decimal tassa = 2;
        public ContoIta(int ID) : base(ID)
        {
        }

        public override bool Ritira(decimal importo)
        {
            return base.Ritira(importo + (importo / 100 * tassa));
        }

        public override void Versa(decimal importo)
        {
            base.Versa(importo - (importo / 100 * tassa));
        }

        public new string ToString()
        {
            return "ID Ita: " + ID + ", Saldo :" + saldo + ".";
        }
    }
}
