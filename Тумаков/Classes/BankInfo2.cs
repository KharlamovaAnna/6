
using System;

namespace Тумаков.Classes
{
    internal class BankInfo2
    {
        private static int count = 759345;
        private readonly string number;
        private decimal balance;
        private readonly BankAccType accType;

        private string Generate_number()
        {
            return count.ToString("D11");
        }

        public BankInfo2(decimal balanceData, BankAccType accType)
        {
            count++;
            this.number = Generate_number();
            this.balance = balanceData;
            this.accType = accType;
        }
        
        public void Info()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accType}");
        }

    }
}
