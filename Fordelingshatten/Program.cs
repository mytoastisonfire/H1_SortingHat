using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshatten
{
    //Model: enum with the different Hogwarts houses
    enum HogwartsHouse
    {
        GRYFFINDOR,
        RAVENCLAW,
        HUFFLEPUFF,
        SLYTHERIN
    }

    //Controller: SortingHatController
    class SortingHatController
    {
        private Random rng = new Random();

        public HogwartsHouse AssignHouse()
        {
            byte randomNumber = Convert.ToByte(rng.Next(0, 4));

            switch (randomNumber)
            {
                case 0:
                    return HogwartsHouse.GRYFFINDOR;
                case 1:
                    return HogwartsHouse.RAVENCLAW;
                case 2:
                    return HogwartsHouse.HUFFLEPUFF;
                case 3:
                    return HogwartsHouse.SLYTHERIN;
                default:
                    throw new Exception("Unexpected error has occurred");
            }
        }
    }
    //View: SortingHatView
    class SortingHatView
    {
        public void DisplayAssignedHouse(HogwartsHouse house)
        {
            Console.WriteLine($"You have been assigned to {house}");
        }
    }

    //Main program that runs on startup
    internal class Program
    {
        static void Main(string[] args)
        {
            SortingHatController controller = new SortingHatController();
            SortingHatView view = new SortingHatView();

            HogwartsHouse house = controller.AssignHouse();
            view.DisplayAssignedHouse(house);
        }
    }
}
