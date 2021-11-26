using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            bool flag = true;
            BankAmount bankAmount = new BankAmount();
            Console.WriteLine("Создался новый счет!");
            Console.Write("Введите сберегательный или текущий счет вы хотите установить : ");
            bankAmount.SetTypeBank(Console.ReadLine());
            Console.WriteLine();
            bankAmount.CheckType();
            Console.WriteLine(string.Format("Ваш уникальный номер {0}", bankAmount.id));
            Dictionary<SHA256, BankAmount> hashList = new Dictionary<SHA256, BankAmount>();
            hashList.Add(bankAmount.HashCode, bankAmount);
            Console.WriteLine();
            while (flag)
            {
                Console.WriteLine("Доступные действия : <перевести> перевести на другой счет; <снять> <положить>(со счета/на счет); <поменять> (сберегательный/текущий) ; <баланс> проверить баланс; <создать> или <удалить аккаунт> аккаунт <выйти> c программы");
                string command = Console.ReadLine().ToLower();
                Console.Clear();

                switch (command)
                {
                    case "снять":
                        Console.WriteLine("Сколько денег хотите снять?");
                        decimal money2;
                        bool flag3 = !decimal.TryParse(Console.ReadLine(), out money2);
                        if (flag3)
                        {
                            Console.WriteLine("Неверный ввод!");
                        }
                        bankAmount.GetFromBalance(money2);
                        break;
                    case "положить":
                        Console.WriteLine("Сколько денег хотите положить?");
                        decimal money;
                        bool flag2 = !decimal.TryParse(Console.ReadLine(), out money);
                        if (flag2)
                        {
                            Console.WriteLine("Неверный ввод!");
                        }
                        bankAmount.GetOnBalance(money);
                        break;
                    case "поменять":
                        bankAmount.SwapBankTypes();
                        break;
                    case "баланс":
                        bankAmount.CheckBalance();
                        break;
                    case "выйти":
                        flag = false;
                        break;
                    case "перевести":
                        Console.WriteLine("Введите сумму перевода");
                        decimal summ;
                        while (!decimal.TryParse(Console.ReadLine(), out summ))
                        {
                            Console.WriteLine("Неверный ввод");
                        }
                        bankAmount.Transaction(summ);
                        break;
                    case "создать":
                        CreatorAccount.CreateAccount(hashList);
                        Console.WriteLine("Аккаунт создан!");
                        break;
                    case "удалить":
                        Console.WriteLine("По какому id удалить собираетесь удалить?");
                        Guid id;
                        if (Guid.TryParse(Console.ReadLine(), out id))
                        {
                            CreatorAccount.DeleteAccount(hashList, id);
                        }
                        else
                        {
                            Console.WriteLine("Неуспешное удаление!");
                        }
                        break;
                }
                BankAmount.Dispose(bankAmount);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
