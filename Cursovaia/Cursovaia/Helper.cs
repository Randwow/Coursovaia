using System;
using System.Collections.Generic;
using System.Text;

namespace Cursovaia
{
    class Helper
    {
        ProspectMemory prospectMemory = new ProspectMemory();
        public void changeMaterial(House customHouse)
        {

            prospectMemory.History.Push(customHouse.SaveMemento());

            CheckData checkData = new CheckData();

            if (customHouse.MaterialHouse == "Wooden house") customHouse.Price -= 15000;
            if (customHouse.MaterialHouse == "Stone house") customHouse.Price -= 50000;
            if (customHouse.MaterialHouse == "Aerated concrete block house") customHouse.Price -= 35000;
            customHouse.MaterialHouse = checkData.checkMaterial(customHouse);
        }
        public void restoreMaterial(House customHouse)
        {
            customHouse.RestoreMemento(prospectMemory.History.Pop());
        }

       
    }
}
