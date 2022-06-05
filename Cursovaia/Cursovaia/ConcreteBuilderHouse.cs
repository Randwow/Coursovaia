using System;
using System.Collections.Generic;
using System.Text;

//Concretnii component (decorator)

namespace Cursovaia
{
    class ConcreteBuilderHouse : HouseBuilder
    {
        public override void SetName(string n)
        {
            house.Name = n;
        }
        public override void SetPrice(double d)
        {
            house.Price += d;
        }
        public override void SetFloor(int floor)
        {
            house.Floor = floor;
        }
        public override void SetWindowNumbers(int wn)
        {
            house.WindowNumbers = wn;
        }
        public override void SetWeightOfHouse(int wh)
        {
            house.WeightOfHouse = wh;
        }
        public override void SetHeightOfHouse(int hh)
        {
            house.HeightOfHouse = hh;
        }
        public override void SetMaterialHouse(string material)
        {
            house.MaterialHouse = material;
        }
        public override double GetPrice()
        {
            return house.Price;
        }


    }
}
