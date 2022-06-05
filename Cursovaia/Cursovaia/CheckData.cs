using System;
using System.Collections.Generic;
using System.Text;

namespace Cursovaia
{
    class CheckData : ReadData
    {
        public override string checkMaterial(HouseBuilder customHouse)
        {
            Console.WriteLine("Select one of 3 materials for your house");
            Console.WriteLine("1) Wooden house ");
            Console.WriteLine("2) Stone house ");
            Console.WriteLine("3) Aerated concrete block house");

            int temp = Convert.ToInt32(Console.ReadLine());
            string[] materialHouse = { "Wooden house", "Stone house", "Aerated concrete block house" };

            while (temp < 1 || temp > 3)
            {
                Console.WriteLine("Select one of 3 materials for your house");
                temp = Convert.ToInt32(Console.ReadLine());
            }
            temp--;
            if (materialHouse[temp] == "Wooden house") customHouse.SetPrice(15000);
            if (materialHouse[temp] == "Stone house") customHouse.SetPrice(50000);
            if (materialHouse[temp] == "Aerated concrete block house") customHouse.SetPrice(35000);

            return materialHouse[temp];
        }
        public override string checkMaterial(House customHouse)
        {
            Console.WriteLine("Select one of 3 materials for your house");
            Console.WriteLine("1) Wooden house ");
            Console.WriteLine("2) Stone house ");
            Console.WriteLine("3) Aerated concrete block house");

            int temp = Convert.ToInt32(Console.ReadLine());
            string[] materialHouse = { "Wooden house", "Stone house", "Aerated concrete block house" };

            while (temp < 1 || temp > 3)
            {
                Console.WriteLine("Select one of 3 materials for your house");
                temp = Convert.ToInt32(Console.ReadLine());
            }
            temp--;
            if(materialHouse[temp] == "Wooden house") customHouse.Price += 15000;
            if (materialHouse[temp] == "Stone house") customHouse.Price += 50000;
            if (materialHouse[temp] == "Aerated concrete block house") customHouse.Price += 35000;

            return materialHouse[temp];
        }

        public override int checkNumFloor(int min, int max)
        {
            Console.WriteLine("Enter numbers of floors (>= 1 and <= 3)");
            int floor = Convert.ToInt32(Console.ReadLine());
            while (floor < min || floor > max)
            {
                Console.WriteLine("Enter numbers of floors (>= 1 and <= 3)");
                floor = Convert.ToInt32(Console.ReadLine());
            }
            return floor;
        }
        public override int checkNumWindows(int min, int max, int floor)
        {
            int number = 0;
            switch (floor)
            {
                case 1:
                    Console.WriteLine("Enter numbers of windows (>= 3 and <= 5)");
                    number = Convert.ToInt32(Console.ReadLine());
                    while (number < min || number > 5)
                    {
                        Console.WriteLine("Enter numbers of windows (>= 3 and <= 5)");
                        floor = Convert.ToInt32(Console.ReadLine());
                    }
                    return number;
                case 2:
                    Console.WriteLine("Enter numbers of windows (>= 6 and <= 10)");
                    number = Convert.ToInt32(Console.ReadLine());
                    while (number < 6 || number > 10)
                    {
                        Console.WriteLine("Enter numbers of windows (>= 6 and <= 10)");
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    return number;
                case 3:
                    Console.WriteLine("Enter numbers of windows (>= 9 and <= 15)");
                    number = Convert.ToInt32(Console.ReadLine());
                    while (number < 9 || number > max)
                    {
                        Console.WriteLine("Enter numbers of windows (>= 9 and <= 15)");
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    return number;
                default:
                    break;
            }
            return number;
        }
        public override int checkNumHeightArea(int min, int max)
        {
            Console.WriteLine("Enter lenght of section (more than 300 and less than 10 000)");
            int lenght = Convert.ToInt32(Console.ReadLine());
            while (lenght < min || lenght > max)
            {
                Console.WriteLine("Enter lenght of section (more than 300 and less than 10 000)");
                lenght = Convert.ToInt32(Console.ReadLine());
            }
            return lenght;
        }
        public override int checkNumWeightArea(int min, int max)
        {
            Console.WriteLine("Enter width of section (more than 300 and less than 10 000)");
            int width = Convert.ToInt32(Console.ReadLine());
            while (width < min || width > max)
            {
                Console.WriteLine("Enter width of section (more than 300 and less than 10 000)");
                width = Convert.ToInt32(Console.ReadLine());
            }
            return width;
        }
        public override int checkNumHeightHouse(int min, int max)
        {
            Console.WriteLine("Enter width of house (more than {0} and less than {1})", min, max);
            int width = Convert.ToInt32(Console.ReadLine());
            while (width < min || width > max)
            {
                Console.WriteLine("Enter width of house (more than {0} and less than {1})", min, max);
                width = Convert.ToInt32(Console.ReadLine());
            }
            return width;
        }

        public override int checkNumWeightHouse(int min, int max)
        {
            Console.WriteLine("Enter lenght of house (more than {0} and less than {1})", min, max);
            int width = Convert.ToInt32(Console.ReadLine());
            while (width < min || width > max)
            {
                Console.WriteLine("Enter lenght of house (more than {0} and less than {1})", min, max);
                width = Convert.ToInt32(Console.ReadLine());
            }
            return width;
        }
    }
}
