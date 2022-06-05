using System;
using System.Collections.Generic;
using System.Text;

namespace Cursovaia
{
    class Director
    {
        private static Director instance;

        private Director()
        {

        }
        public static Director GetInstance()
        {
            if (instance == null)
                instance = new Director();
            return instance;
        }

        public House buildSimpleHouse(HouseBuilder houseBuilder)
        {
            CheckData checkData = new CheckData();

            houseBuilder.CreateHouse();
            houseBuilder.SetName("Base house ");
            houseBuilder.SetFloor(checkData.checkNumFloor(1, 3));
            houseBuilder.SetWindowNumbers(checkData.checkNumWindows(3, 15, houseBuilder.house.Floor));
            houseBuilder.house.WeightOfArea = checkData.checkNumWeightArea(300, 10000);
            houseBuilder.house.HeightOfArea = checkData.checkNumHeightArea(300, 10000);
            houseBuilder.house.TotalArea = houseBuilder.house.WeightOfArea * houseBuilder.house.HeightOfArea;
            houseBuilder.house.TotalPer = (2 * houseBuilder.house.WeightOfArea) + (2 * houseBuilder.house.HeightOfArea);
            houseBuilder.SetWeightOfHouse(checkData.checkNumWeightHouse(50, houseBuilder.house.WeightOfArea - 3));
            houseBuilder.SetHeightOfHouse(checkData.checkNumHeightHouse(50, houseBuilder.house.HeightOfArea - 3));
            houseBuilder.house.TotalAreaOfHouse = houseBuilder.house.HeightOfHouse * houseBuilder.house.WeightOfHouse;
            houseBuilder.SetMaterialHouse(checkData.checkMaterial(houseBuilder));
            houseBuilder.SetPrice(100000.00);
            return houseBuilder.house;
        }

        public House buildSmartHouse(HouseBuilder houseBuilder)
        {
            houseBuilder = new SmartHouse(houseBuilder);
            houseBuilder.SetName("with smart functionality ");
            houseBuilder.SetPrice(15000.00);
            return houseBuilder.house;
        }
        public House addSwimmingPool(HouseBuilder houseBuilder)
        {
            houseBuilder = new SwimmingPool(houseBuilder);
            houseBuilder.SetName("with swimming pool ");
            houseBuilder.SetPrice(10000.00);
            return houseBuilder.house;
        }
        public House addVeranda(HouseBuilder houseBuilder)
        {
            houseBuilder = new HouseWithVeranda(houseBuilder);
            houseBuilder.SetName(" and veranda");
            houseBuilder.SetPrice(5000.00);
            return houseBuilder.house;
        }
    }
}
