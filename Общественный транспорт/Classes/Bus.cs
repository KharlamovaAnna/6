
using System;

namespace Общественный_транспорт.Classes
{
    internal class Bus : PublicTransport
    {
        public int num;
        public int route //номер маршрута автобуса
        {
            get { return num; }
            set { num = value; }
        }

        public int seat; //количество мест
        public override int seats
        {
            get { return seat; }
            set { seat = value; }
        }

        public int pprice; //цена за поездку
        public override int price
        {
            get { return pprice; }
            set { pprice = value; }
        }
    }
}
