using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PublicBus : Transport
    {

       
        public PublicBus(string id, double mileage) : base(id, mileage)
        {
        }

        public override void Move(double distanceKm)
        {
            base.Move(distanceKm);
        }
    }
}
