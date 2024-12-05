

using System;

namespace Тумаков.Classes
{
    public enum BankAccType
    {
        Текущий,
        Сберегательный
    }
    internal class BankInfo
    {
        private decimal AccNumber;
        private BankAccType AccType;
        private decimal AccBalance;

        public BankInfo(decimal AccNumber, decimal AccBalance, BankAccType AccType)
        {
            this.AccNumber = AccNumber;
            this.AccBalance = AccBalance;
            this.AccType = AccType;
        }
        public void Info()
        {
            Console.WriteLine($"Номер счета: {AccNumber}");
            Console.WriteLine($"Баланс: {AccBalance}");
            Console.WriteLine($"Тип: {AccType}");
        }
    }

}
