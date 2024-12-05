
using System;
using System.Collections.Generic;
using Общественный_транспорт.Classes;

namespace Общественный_транспорт
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.route = 22;
            bus.seats = 46;
            Console.WriteLine($"Автобус следует по маршруту: {bus.route}");
            Console.WriteLine($"Количество сидячих мест: {bus.seats}");
            List<string> busPayment = new List<string>() { "Картой", "Наличными", "Транспортной картой" };
            PublicTransport.PrintPaymentMethod(busPayment);
            Console.WriteLine();

            Subway subway = new Subway();
            subway.seats = 42;
            KazanMetroStations currentStation = KazanMetroStations.Дубравная;
            KazanMetroStations nextStation = Subway.GetNextStation(currentStation);
            Console.WriteLine($"Станция {currentStation}");
            Console.WriteLine($"Будьте осторожны, двери закрываются, следующая станция - {nextStation}");
            Console.WriteLine($"Количество сидячих мест: {subway.seats}");

            List<string> subwayPayment = new List<string>() { "Картой", "Наличными", "Транспортной картой" };
            PublicTransport.PrintPaymentMethod(subwayPayment);
            Console.WriteLine();

            foreach (string money in subwayPayment)
            {
                switch (money)
                {
                    case "Картой":
                        subway.price = 38;
                        Console.WriteLine($"Цена при оплате {money} - {subway.price}");
                        break;
                    case "Наличными":
                        subway.price = 42;
                        Console.WriteLine($"Цена при оплате {money} - {subway.price}");
                        break;
                    case "Транспортной картой":
                        subway.price = 38;
                        Console.WriteLine($"Цена при оплате {money} - {subway.price}");
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
