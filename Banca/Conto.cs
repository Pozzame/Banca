using System;
using System.Collections.Generic;
using System.Text;

namespace Banca
{
    abstract class Conto
    {
        protected decimal saldo;
        protected int ID;

        public Conto(int ID)
        {
            this.ID = ID;
        }

        public virtual decimal MostraSaldo()
        {
            return saldo;
        }

        public int MostraID()
        {
            return ID;
        }

        public virtual void Versa(decimal importo)
        {
            saldo += importo;
            Console.WriteLine("Operazione sul conto " + MostraID() + " eseguita. Nuovo saldo: " + MostraSaldo());
        }

        public virtual bool Bonifica(decimal importo, Conto dest)
        {
            if (Ritira(importo))
            {
                dest.Versa(importo);
                return true;
            }
            else return false;
        }

        public virtual bool Ritira(decimal importo)
        {
            if (saldo >= importo)
            {
                saldo -= importo;
                Console.WriteLine("Operazione sul conto " + MostraID() + " eseguita. Nuovo saldo: " + MostraSaldo());
                return true;
            }
            else
            {
                Console.WriteLine("Operazione annullata! ID Conto: " + MostraID() + " non ha abbastanza saldo. Saldo attuale: " + MostraSaldo());
                return false;
            }
        }

        public override string ToString()
        {
            return "ID: " + ID + ", Saldo :" + saldo + ".";
        }

        public bool Equals(Conto altro)
        {
            if (ID == altro.MostraID() && saldo == altro.MostraSaldo())
                return true;
            else return false;
        }
    }
}
