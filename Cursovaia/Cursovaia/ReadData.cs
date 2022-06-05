using System;
using System.Collections.Generic;
using System.Text;

namespace Cursovaia
{
    abstract class ReadData
    {
        public abstract int checkNumFloor(int min, int max);
        public abstract int checkNumWindows(int min, int max, int floor);
        public abstract int checkNumWeightArea(int min, int max);
        public abstract int checkNumHeightArea(int min, int max);
        public abstract int checkNumWeightHouse(int min, int max);
        public abstract int checkNumHeightHouse(int min, int max);
        public abstract string checkMaterial(House customHouse);
        public abstract string checkMaterial(HouseBuilder customHouse);


    }
}