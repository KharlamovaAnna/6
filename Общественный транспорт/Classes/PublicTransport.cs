
using System.Collections.Generic;
using System;

namespace Общественный_транспорт.Classes
{
    abstract class PublicTransport
    {
        public abstract int seats { get; set; } //кол-во мест
        public abstract int price { get; set; } //стоимость проезда

        
        public static void PrintPaymentMethod(List<string> paymentMethod) //способ оплаты
        {
            if (paymentMethod == null || paymentMethod.Count == 0)
            {
                Console.WriteLine("Способы оплаты не указаны.");
                return;
            }

            Console.WriteLine("Способы оплаты:");
            foreach (string method in paymentMethod)
            {
                Console.WriteLine($"- {method}");

            }
        }

    }
}
