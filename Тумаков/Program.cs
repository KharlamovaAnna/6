using System;
using System.Security.Principal;
using Тумаков.Classes;
using static Тумаков.Classes.BankInfo;

namespace Тумаков
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
        public static void Task1()
        {
            /*Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
            доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
            вывести информацию об объекте класса на печать*/
            Console.WriteLine("Задание 7.1");
            BankInfo info = new BankInfo(5438545734, 23000, BankAccType.Сберегательный);
            info.Info();
            Console.ReadLine();
        }
        public static void Task2()
        {
            /*Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            номер счета генерировался сам и был уникальным.Для этого надо создать в классе
            статическую переменную и метод, который увеличивает значение этого переменной*/
            Console.WriteLine("Задание 7.2");
            BankInfo2 info_2 = new BankInfo2(10000, BankAccType.Текущий);
            info_2.Info();
            Console.ReadLine();

        }
        public static void Task3()
        {
            Console.WriteLine("Упражнение 7.3");
            BankInfo3 account = new BankInfo3(100, BankAccType.Текущий);

            account.Info();
            account.Deposit(234);
            account.Withdraw(10);
            account.Info();
            Console.ReadLine();
        }
    }
}
