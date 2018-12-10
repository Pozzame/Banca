using System;
using System.Collections.Generic;
using System.Text;

namespace Banca
{
    class ContoCayman : Conto
    {
        public ContoCayman(int ID) : base(ID)
        {
        }

        public new string ToString()
        {
            return "ID Cayman: " + ID + ", Saldo :" + saldo + ".";
        }
    }
}
