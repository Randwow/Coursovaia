using System;
using System.Collections.Generic;
using System.Text;

namespace Cursovaia
{
    class ProjectFacade
    {

        //add more
        Director director = Director.GetInstance();
        HouseBuilder houseBuilder = new ConcreteBuilderHouse();

        public void StartUploadData(House house)
        {
            ToExternalTXT toexternaltxt = new ToExternalTXT();
            toexternaltxt.CreateFile();
            toexternaltxt.DateToFile(house);
            ToExternalDOC toExternalDOC = new ToExternalDOC();
            toExternalDOC.CreateFile();
            toExternalDOC.DateToFile(house);
        }

        //Start builder pattern
        public House BuildHouse()
        {

            House customHouse = director.buildSimpleHouse(houseBuilder);
            return customHouse;

        }

        public House doHouseSmart()
        {
            House customHouse = director.buildSmartHouse(houseBuilder);
            customHouse = houseBuilder.house;
            return customHouse;
        }
        public House doHouseWithSwimmingPool()
        {
            House customHouse = director.addSwimmingPool(houseBuilder);
            customHouse = houseBuilder.house;
            return customHouse;
        }
        public House doHouseWithVeranda()
        {
            House customHouse = director.addVeranda(houseBuilder);
            customHouse = houseBuilder.house;
            return customHouse;
        }
    }
}
