
using System;

namespace Тумаков.Classes
{
    internal class BankInfo3
    {
        private static int counter = 45567456;
        private readonly string number;
        private decimal balance;
        private readonly BankAccType accType;

        public BankInfo3(decimal balanceData, BankAccType accountType)
        {
            counter++;
            this.number = Generate_number();
            this.balance = balanceData;
            this.accType = accountType;
        }
      
        private string Generate_number()
        {
            return counter.ToString("D11");
        }

        public void Deposit(decimal sum)
        {
            if (sum > 0)
            {
                balance += sum;
                Console.WriteLine($"Вы пополнили на {sum}. Ваш новый баланс {balance}");
            }
            else
            {
                Console.WriteLine("Сумма не может быть отрицательной!");
            }
        }

        public void Withdraw(decimal sum)
        {
            if (sum <= 0)
            {
                Console.WriteLine("Сумма вывода должна быть положительной");
                return;
            }
            else if (sum > balance)
            {
                Console.WriteLine("У вас недостаточно средств");
            }
            else
            {
                balance -= sum;
                Console.WriteLine($"Вы сняли {sum}. Ваш новый баланс {balance}");
            }
        }

        public void Info()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accType}");

        }
    }
}
