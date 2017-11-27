using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class UI
    {


        public void TitleScreen()
        {
            Console.WriteLine("Welcome to Lemonade Stand. Press any button to continue.");
            Console.ReadKey();
            GetDays();
        }

        public void GetDays()
        {
            Console.WriteLine("How many days would you like to play for? (enter a number between 7 and 100)");
            int numDays = Convert.ToInt32(Console.ReadLine());
            if (Between7And100(numDays)){
                Game gameInstance = new Game(numDays);
                gameInstance.GameLoop();
            }
            else
            {
                Console.WriteLine("please enter a number between 7 and 100");
                GetDays();
            }
        }

        public bool Between7And100(int numDays)
        {
            if(numDays>6 || numDays < 101)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        public int displayPurchaseScreen(Inventory playerInventory)
        {
            Console.WriteLine("Inventory/Purchasing");
            Console.WriteLine("You have:");
            Console.WriteLine(playerInventory.getCups() + "Paper Cups");
            Console.WriteLine(playerInventory.getNumOfLemons() + "Lemons");
            Console.WriteLine(playerInventory.getSugar() + "Cups of Sugar");
            Console.WriteLine(playerInventory.getIceCubes() + "Ice Cubes");
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1. buy more cups.");
            Console.WriteLine("2. buy more Lemons.");
            Console.WriteLine("3. buy more sugar.");
            Console.WriteLine("4. buy more ice cubes");
            Console.WriteLine("5. Continue");
            Console.WriteLine("6. Quit");
        }

        public bool isValidInventoryInput(int inventoryInput)
        {
            if (inventoryInput > 0 && inventoryInput < 7)
            {
                return true;
            }
            else return false;
        }

        public void cupsScreen(Player player)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("you have " + playerInventory.getCups() + " cups and " +player.getMoney()+" dollars.\n how many would you like to purchase?");
            Console.WriteLine("1. 25 cups for $0.76");
            Console.WriteLine("2. 50 cups for $1.62");
            Console.WriteLine("1. 100 cups for $2.84");
        }

        public void lemonScreen(Player player)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("you have " + playerInventory.getNumOfLemons() + " Lemons and " + player.getMoney() + " dollars .\n how many would you like to purchase?");
            Console.WriteLine("1. 10 lemons for $0.73");
            Console.WriteLine("2. 30 lemons for $2.22");
            Console.WriteLine("1. 75 lemons for $4.48");
        }

        public void sugarScreen(Player player)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("you have " + playerInventory.getSugar() + " cups of sugar and " + player.getMoney() + " dollars.\n how many would you like to purchase?");
            Console.WriteLine("1. 8 cups for $0.65");
            Console.WriteLine("2. 20 cups for $1.74");
            Console.WriteLine("1. 48 cups for $3.37");
        }

        public void iceScreen(Player player)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("you have " + playerInventory.getIceCubes() + " ice cubes and " + player.getMoney() + " dollars.\n how many would you like to purchase?");
            Console.WriteLine("1. 100 ice cubes for $0.78");
            Console.WriteLine("2. 250 ice cubes for $2.12");
            Console.WriteLine("1. 500 ice cubes for $3.72");
        }
    }

}
