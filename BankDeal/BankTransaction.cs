using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDeal
{
    class BankTransaction
    {

        public enum TypeTransaction
        {
            Withdrawal,
            Replenishment,
            Transfer
        }
        public readonly DateTime dateTime = new DateTime();
        public readonly decimal summ;
        public readonly TypeTransaction typeTransaction;
        internal BankTransaction(decimal summ, TypeTransaction type)
        {
            this.summ = summ;
            dateTime = DateTime.Now;
            typeTransaction = type;
        }
    }
}
