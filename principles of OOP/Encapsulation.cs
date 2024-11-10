using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_OOP
{
    internal class Encapsulation
    {
        public class BankAccount
        {
            private decimal balance;

            public BankAccount(decimal initialBalance)
            {
                balance = initialBalance;
            }

            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Сумма депозита должна быть положительной.");
                    return;
                }
                balance += amount;
                Console.WriteLine($"Внесенный депозит: {amount}. Текущий баланс: {balance}");
            }

            public void Withdraw(decimal amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Сумма вывода должна быть положительной.");
                    return;
                }
                if (amount > balance)
                {
                    Console.WriteLine("Недостаточно средств.");
                    return;
                }
                balance -= amount;
                Console.WriteLine($"Вывод суммы: {amount}. Текущий баланс: {balance}");
            }

            public decimal GetBalance()
            {
                return balance;
            }
        }
    }
}
