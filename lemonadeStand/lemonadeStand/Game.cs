using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Game
    {
        private int numDays;
        UI UIInstance = new UI();
        Player player1 = new Player();

        public Game(int numDays)
        {
            this.numDays = numDays;
        }

        public void GameLoop()
        {
            inventoryScreen();
        }

        public void inventoryScreen()
        {
            UIInstance.displayPurchaseScreen(player1.getInventory());
            int inventoryInput = Convert.ToInt32(Console.ReadLine());
            if (UIInstance.isValidInventoryInput(inventoryInput)){
                inventorySwitch(inventoryInput);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid input");
                inventoryScreen();
            }
        }

        public void inventorySwitch(int inventoryInput)
        {
            string userChoice;

            switch (inventoryInput)
            {
                case 1:
                    Console.Clear();
                    UIInstance.cupsScreen(player1);
                    userChoice = Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    UIInstance.lemonScreen(player1);
                    userChoice = Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    UIInstance.sugarScreen(player1);
                    userChoice = Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    UIInstance.iceScreen(player1);
                    userChoice = Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    lemonadeCreation();
                    break;
                case 6:
                    //quit
                    break;
            }
    }
}
