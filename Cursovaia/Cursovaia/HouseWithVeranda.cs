using System;
using System.Collections.Generic;
using System.Text;

// CONCRETE DECORATOR

namespace Cursovaia
{
    class HouseWithVeranda : HouseWithMoreFunc
    {
        public HouseWithVeranda(HouseBuilder house) : base(house)
        {
            this.house = house;
        }
        public override void SetName(string n)
        {
            house.house.Name += n;
        }
        public override void SetPrice(double d)
        {
            house.house.Price += d;
        }
        public override double GetPrice()
        {
            return house.house.Price;
        }
    }
}
