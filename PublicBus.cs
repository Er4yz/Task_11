using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PublicBus : Transport // PublicBus наследуется от Transport
    {
        #region Доп.члены
        public int PassengerCapacity { get; } //Вместимость пассажиров
        public int CurrentPassengers { get; private set; } //Текущее количество пассажиров
        #endregion

        #region Конструктор
        /// <summary>
        /// Принимает параметры string id, double mileage, int passengerCapacity и передает первые два в base(id, mileage)
        /// </summary>
        /// <param name="id">Имя</param>
        /// <param name="mileage">Пробег</param>
        /// <param name="passengerCapacity">Пассажировместимость</param>
        public PublicBus(string id, double mileage, int passengerCapacity) : base(id, mileage)
        {
            PassengerCapacity = passengerCapacity;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Производит посадку с контролем лимита вместимости;
        /// </summary>
        /// <param name="count">Счетчик</param>
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

        /// <summary>
        /// Переопределяет базовое движение
        /// </summary>
        /// <param name="distanceKm">Перемещение</param>
        public override void Move(double distanceKm)
        {
            base.Move(distanceKm);
            Console.WriteLine("Автобус следует по городскому маршруту с остановками");
        }
        #endregion
    }
}
