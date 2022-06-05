using System;
using System.Collections.Generic;
using System.Text;

// DECORATOR

namespace Cursovaia
{
    //Decorator
    abstract class HouseWithMoreFunc : HouseBuilder
    {
        protected HouseBuilder house;
        public HouseWithMoreFunc(HouseBuilder house)
        {
            this.house = house;
        }
    }
}