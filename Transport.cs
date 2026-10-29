using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Transport
    {
        #region Поля
        protected string TransportId;
        protected int CurrentSpeed;
        private double _mileageKm;
        #endregion

        #region Свойства
        // => -- лямбда-оператор, который возвращает это в это, а так же сокращение методов, свойств и конструкторов.
        public string ID => TransportId;
        public double Mileage => _mileageKm;
        public int Speed { get => CurrentSpeed; protected set => CurrentSpeed = Math.Max(0, value); }
        #endregion

        #region Конструктор
        /// <summary>
        /// Инициализирует идентификатор и базовый пробег.
        /// </summary>
        /// <param name="id">Имя</param>
        /// <param name="mileage">Пробег</param>
        public Transport(string id, double mileage)
        {
            this.TransportId = id;
            this._mileageKm = mileage;
        }
        #endregion

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
            Console.WriteLine($"Mileage = {Mileage}");
            Console.WriteLine($"Speed = {Speed}");
        }
    }
}
