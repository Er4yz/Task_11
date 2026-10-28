using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Transport 
    {
        protected string TransportId;
        protected int CurrentSpeed;
        private double _mileageKm;

        public string ID => TransportId;
        public double Mileage => _mileageKm;
        public int Speed { get => CurrentSpeed; protected set => CurrentSpeed = Math.Max(0, value); }

        public Transport(string id, double mileage)
        {
            this.TransportId = id;
            this._mileageKm = mileage;
        }
        /// <summary>
        /// Увеличивает общий пробег _mileageKm += distanceKm и выводит базовый отчет о перемещении;
        /// </summary>
        /// <param name="distanceKm">Перемещение</param>
        public virtual void Move(double distanceKm)
        {
            _mileageKm += distanceKm;
            Console.WriteLine($"{Mileage}");
        }

        /// <summary>
        /// Выводит в консоль сводку по Id, скорости и пробегу.
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID = {ID}");
            Console.WriteLine($"... = {Mileage}");
            Console.WriteLine($"... = {Speed}");
        }
    }
}
