using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp11;
using ConsoleApp11.NewFolder1;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Transport transport = new Transport("1", 150654);

            //transport.Move(325);
            //transport.DisplayInfo();
            #region Массив
            Transport[] fleet = new Transport[4] // Автопарк
            {
                new PublicBus("Автобус 1", 40.5, 25),
                new ElectricScooter("Автобус 2", 45.6, 85),
                new ElectricScooter("Автобус 3", 42.3, 100),
                new CargoTruck("Автобус 4", 44.7, 20, true)
            };
            #endregion
            
            #region Цикл
            foreach (var bus in fleet)
            {
                {
                    Console.WriteLine($"\nПеремещаем {bus.ID}");
                    bus.DisplayInfo();
                    Console.WriteLine($"{bus.ID} обошел парк:");
                    bus.Move(10.0);
                }
            }
            #endregion

            #region Оператор is
            
            #endregion

        }
    }
}
