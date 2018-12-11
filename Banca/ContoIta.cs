using System;
using System.Collections.Generic;
using System.Text;

namespace Banca
{
    class ContoIta : Conto
    {
        public static decimal Tassa { get; set; }
        
        public ContoIta(int ID) : base(ID)
        {
        }

        public override bool Ritira(decimal importo)
        {
            return base.Ritira(importo + (importo / 100 * Tassa));
        }

        public override void Versa(decimal importo)
        {
            base.Versa(importo - (importo / 100 * Tassa));
        }

        public new string ToString()
        {
            return "ID Ita: " + ID + ", Saldo :" + saldo + ".";
        }
    }
}
