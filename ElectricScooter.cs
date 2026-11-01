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
        #region Доп.члены
        private int _batteryPercent; //Заряд батареи
        #endregion

        #region Конструктор
        /// <summary>
        /// Принимает параметры string id, double mileage, int batteryPercent с вызовом base(id, mileage)
        /// </summary>
        /// <param name="id">Имя</param>
        /// <param name="mileage">Пробег</param>
        /// <param name="batteryPercent">Заряд батареи</param>
        public ElectricScooter(string id, double mileage, int batteryPercent) : base(id, mileage) 
        {
            _batteryPercent = batteryPercent;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Восстанавливает заряд батареи до 100%
        /// </summary>
        public void Recharge()
        {
            if (_batteryPercent <= 0)
            {
                _batteryPercent = 100;
            }
        }

        /// <summary>
        /// Переопределяет метод: проверяет заряд (расход 2% на 1 км). Если заряда недостаточно, движение блокируется; при успехе расходует заряд и вызывает base.Move(distanceKm).
        /// </summary>
        /// <param name="distanceKm">Перемещение</param>
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
        #endregion
    }
}
