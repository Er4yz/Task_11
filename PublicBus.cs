using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PublicBus : Transport // PublicBus наследуется от Transport
    {
        public int PassengerCapacity { get; } //Вместимость пассажиров
        public int CurrentPassengers { get; private set; } //Текущее количество пассажиров

        public PublicBus(string id, double mileage, int passengerCapacity) : base(id, mileage)
        {
            PassengerCapacity = passengerCapacity;
        }

        public void BoardPassengers(int count)
        {
            if (CurrentPassengers + count <= PassengerCapacity)
            {
                CurrentPassengers = CurrentPassengers + count;
            }
            else
            {
                Console.WriteLine("Места в автобусе недостаточно");
            }
        }

        public override void Move(double distanceKm)
        {
            base.Move(distanceKm);
            Console.WriteLine("Автобус следует по городскому маршруту с остановками");
        }
    }
}
