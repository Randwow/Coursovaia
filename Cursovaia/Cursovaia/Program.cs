using System;

namespace Cursovaia
{
    class Program
    {

        static void Main(string[] args)
        {
            // start facade
            ProjectFacade projectFacade = new ProjectFacade();
            // facade buid house
            House customHouse = projectFacade.BuildHouse();
            
            Helper helper = new Helper();

            Console.WriteLine(customHouse);

            Console.WriteLine("Do you want to change the material of the house? (Enter 1 or 2)" +
                "\n 1)Yes " +
                "\n 2)No");

            int chooseChangeMat = Convert.ToInt32(Console.ReadLine());
            if (chooseChangeMat == 1)
            {
                helper.changeMaterial(customHouse);
                Console.WriteLine(customHouse);
                Console.WriteLine("Do you want to restore the material of the house? (Enter 1 or 2)" +
                "\n 1)Yes " +
                "\n 2)No");
                chooseChangeMat = Convert.ToInt32(Console.ReadLine());
                if (chooseChangeMat == 1) helper.restoreMaterial(customHouse);
                Console.WriteLine(customHouse);
            }

            



            Console.WriteLine("Do you want to add some more functionality? (Enter 1 or 2)" +
            "\n 1)Yes " +
            "\n 2)No");
            int chooseAddFunc = Convert.ToInt32(Console.ReadLine());
            int choose;
            if (chooseAddFunc == 1)
            {
                Console.WriteLine("Do you want to do house smart? \n" +
               "1) Yes \n" +
               "2) No ");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1) customHouse = projectFacade.doHouseSmart();

                Console.WriteLine("Do you want to add house to house veranda? \n" +
                    "1) Yes \n" +
                    "2) No ");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1) customHouse = projectFacade.doHouseWithVeranda();

                Console.WriteLine("Do you want to add house to house swimming pool? \n" +
                    "1) Yes \n" +
                    "2) No ");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1) customHouse = projectFacade.doHouseWithSwimmingPool();
            }
            Console.WriteLine(customHouse);


            projectFacade.StartUploadData(customHouse);
            Console.WriteLine("Your word file and txt was generated");    
            Console.ReadKey();
        }
    }
}
