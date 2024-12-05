using System;
using System.Collections.Generic;

namespace Общественный_транспорт.Classes
{
    public enum KazanMetroStations
    {
       Авиастроительная,
       Северный_Вокзал,
       Яшьлек,
       Козья_Слобода,
       Кремлевская,
       Площадь_Тукая,
       Суконная_Слобода,
       Аметьево,
       Горки,
       Проспект_Победы,
       Дубравная
    }
    internal class Subway : PublicTransport
    {
        public int seat;
        public override int seats
        {
            get { return seat; }
            set { seat = value; }
        }

        public int pprice; 
        public override int price //цена за поездку
        {
            get { return pprice; }
            set { pprice = value; }
        }

        public static KazanMetroStations GetNextStation(KazanMetroStations currentStation)
        {
            int currentValue = (int)currentStation;
            int nextValue = (currentValue + 1) % Enum.GetNames(typeof(KazanMetroStations)).Length;
            return (KazanMetroStations)nextValue;   
        }

        
    }
}
