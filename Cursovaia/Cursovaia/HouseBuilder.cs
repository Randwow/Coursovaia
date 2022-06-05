using System;
using System.Collections.Generic;
using System.Text;

//Builder

// Component

namespace Cursovaia
{
    abstract class HouseBuilder
    {
        public House house { get; private set; }

        public void CreateHouse()
        {
            house = new House();
        }
        public abstract void SetName(string n);
        public abstract void SetPrice(double d);
        public virtual void SetFloor(int floor) { }

        public virtual void SetWindowNumbers(int wn) { } //vir
        public virtual void SetWeightOfHouse(int wh) { }//v
        public virtual void SetHeightOfHouse(int hh) { }//v
        public virtual void SetMaterialHouse(string material) { } //v

        public abstract double GetPrice();

    }
}
