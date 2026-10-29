using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp11
{
    public sealed class ElectricScooter : Transport
    {
        private int _batteryPercent;

        public ElectricScooter(string id, double mileage, int batteryPercent) : base(id, mileage)
        {
            _batteryPercent = batteryPercent;
        }

        public void Recharge()
        {
            if (_batteryPercent <= 0)
            {
                _batteryPercent = 100;
            }
        }

        public override void Move(double distanceKm)
        {
            int MinusBattery = (int) distanceKm * 2;
            if (_batteryPercent >= MinusBattery)
            {
                _batteryPercent -= MinusBattery;
                base.Move(distanceKm);
            }
            else
            {
                Console.WriteLine("Заряда недостаточно. Движение заблокировано!");
            }
        }
    }
}
