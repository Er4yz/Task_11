using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp11.NewFolder1
{
    public class CargoTruck : Transport
    {
        #region Доп.члены
        public double MaxCargoTons { get; } // Макс.вес груза
        public bool HasTrailer { get; set; } // Имеет прицеп
        #endregion

        #region Конструктор
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Имя</param>
        /// <param name="mileage">пробег</param>
        /// <param name="maxCargoTons">Макс.вес груза</param>
        /// <param name="hasTrailer">Имеет прицеп</param>
        public CargoTruck(string id, double mileage, double maxCargoTons, bool hasTrailer) : base(id, mileage)
        {
            MaxCargoTons = maxCargoTons;
            HasTrailer = hasTrailer;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Вызывает base.DisplayInfo() и дописывает статус прицепа и грузоподъемность.
        /// </summary>
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Статус прицепа: {HasTrailer}.\nСтатус грузоподъемность: {MaxCargoTons}");
        }

        /// <summary>
        /// Специфичный метод выгрузки кузова.
        /// </summary>
        public void UnloadCargo()
        {
            Console.WriteLine("Кузов загрузка...30%...");
        }
        #endregion

    }
}
