using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BankDeal
{
    class CreatorAccount
    {
        public static void CreateAccount(Dictionary<SHA256, BankAmount> hashList)
        {
            BankAmount bankAmount = new BankAmount();
            hashList.Add(bankAmount.HashCode, bankAmount);
        }

        public static void DeleteAccount(Dictionary<SHA256, BankAmount> hashList, Guid id)
        {
            foreach (var bankAmount in hashList)
            {
                if (bankAmount.Value.id == id)
                {
                    hashList.Remove(bankAmount.Key);
                    Console.WriteLine("Успешное удаление!");
                }
            }
        }

    }
}
