﻿using System;
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
            Console.Clear();
            Console.WriteLine("Welcome to Lemonade Stand.\n");
            DB dbConnection = new DB();
            dbConnection.getHighScores();
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
            Console.Clear();
            GetDays();
        }

        public void GetDays()
        {
            Game gameHelperObject = new Game();
            Console.WriteLine("How many days would you like to play for? (enter a number between 7 and 100)");
            string numDays = Console.ReadLine();
            if (gameHelperObject.inputValidation(numDays, 7, 100)) {
                Game gameInstance = new Game(Convert.ToInt32(numDays));
                gameInstance.GameLoop();
            }
            else
            {
                Console.WriteLine("please enter a number between 7 and 100");
                GetDays();
            }
        }

        public string getUserName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        public void displayPurchaseScreen(Player player, Weather forcast)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("Inventory/Purchasing");
            Console.WriteLine("The Forcast for tomorrow is: " + forcast.getTempurature() + " and " + forcast.getWeather());
            Console.WriteLine("You have:");
            Console.WriteLine("$" + player.getMoney());
            Console.WriteLine(playerInventory.getCups() + " Paper Cups");
            Console.WriteLine(playerInventory.getNumOfLemons() + " Lemons");
            Console.WriteLine(playerInventory.getSugar() + " Cups of Sugar");
            Console.WriteLine(playerInventory.getIceCubes() + " Ice Cubes");
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1. buy more cups.");
            Console.WriteLine("2. buy more Lemons.");
            Console.WriteLine("3. buy more sugar.");
            Console.WriteLine("4. buy more ice cubes");
            Console.WriteLine("5. Continue");
        }

        public void cupsScreen(Player player)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("you have " + playerInventory.getCups() + " cups and " + player.getMoney() + " dollars.\n how many would you like to purchase?");
            Console.WriteLine("1. 25 cups for $0.76");
            Console.WriteLine("2. 50 cups for $1.62");
            Console.WriteLine("3. 100 cups for $2.84");
            Console.WriteLine("4. Buy None");
        }

        public void lemonScreen(Player player)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("you have " + playerInventory.getNumOfLemons() + " Lemons and " + player.getMoney() + " dollars .\n how many would you like to purchase?");
            Console.WriteLine("1. 10 lemons for $0.73");
            Console.WriteLine("2. 30 lemons for $2.22");
            Console.WriteLine("3. 75 lemons for $4.48");
            Console.WriteLine("4. Buy None");
        }

        public void sugarScreen(Player player)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("you have " + playerInventory.getSugar() + " cups of sugar and " + player.getMoney() + " dollars.\n how many would you like to purchase?");
            Console.WriteLine("1. 8 cups for $0.65");
            Console.WriteLine("2. 20 cups for $1.74");
            Console.WriteLine("3. 48 cups for $3.37");
            Console.WriteLine("4. Buy None");
        }

        public void iceScreen(Player player)
        {
            Inventory playerInventory = player.getInventory();
            Console.WriteLine("you have " + playerInventory.getIceCubes() + " ice cubes and " + player.getMoney() + " dollars.\n how many would you like to purchase?");
            Console.WriteLine("1. 100 ice cubes for $0.78");
            Console.WriteLine("2. 250 ice cubes for $2.12");
            Console.WriteLine("3. 500 ice cubes for $3.72");
            Console.WriteLine("4. Buy None");
        }

        public Lemonade lemonadeCreation()
        {

            int lemonsCount = addLemonsToRecipe();

            int sugarCount = addSugarToRecipe();

            int iceCubeCount = addIceCubesToRecipe();

            double price = addPriceToRecipe();

            displayCurrentLemonade(lemonsCount, sugarCount, iceCubeCount, price);

            string yesOrNo = Console.ReadLine();

            if (yesOrNo == "yes")
            {
                return new Lemonade(lemonsCount, sugarCount, iceCubeCount, price);
            }
            else
            {
                Console.Clear();
                return lemonadeCreation();
            }
        }

        public void displayCurrentLemonade(int lemonsCount,int sugarCount, int iceCubeCount, double price)
        {
            Console.WriteLine("Your lemonade:");
            Console.WriteLine(lemonsCount + " lemons");
            Console.WriteLine(sugarCount + " cups of sugar");
            Console.WriteLine(iceCubeCount + " ice cubes");
            Console.WriteLine("price: " + price);
            Console.WriteLine("Is this acceptable? ('yes' or 'no')");
        }
        public int addLemonsToRecipe()
        {
            Console.WriteLine("How many lemons would you like to add to your recipe?");
            string lemonsString = Console.ReadLine();
            int lemonCount;
            if (!int.TryParse(lemonsString, out lemonCount))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                addLemonsToRecipe();
            }
            else
            {
                return lemonCount;
            }
            return 0;
        }

        public int addSugarToRecipe()
        {
            Console.WriteLine("How much sugar would you like to add to your recipe?");
            string sugarString = Console.ReadLine();
            int sugarCount;
            if (!int.TryParse(sugarString, out sugarCount))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                addSugarToRecipe();
            }
            else
            {
                return sugarCount;
            }
            return 0;
        }

        public int addIceCubesToRecipe()
        {
            Console.WriteLine("How many ice cubes would you like to add to your recipe?");
            string iceCubeString = Console.ReadLine();
            int iceCubeCount;
            if (!int.TryParse(iceCubeString, out iceCubeCount))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                addIceCubesToRecipe();
            }
            else
            {
                return iceCubeCount;
            }
            return 0;
        }

        public double addPriceToRecipe()
        {
            Console.WriteLine("What is the price you would like to charge?");
            string priceString = Console.ReadLine();
            double price;
            if (!double.TryParse(priceString, out price))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                addPriceToRecipe();
            }
            else
            {
                return price;
            }
            return 0;
        }

        public void endScreen(Player player1)
        {
            DB dbConnection = new DB();
            dbConnection.addTodataBase(player1.getName(), (player1.getMoney()));
            Console.WriteLine("Congradulations! " + player1.getName() + " You made $" + (player1.getMoney() - 20));
            Console.WriteLine("Press 1 to restart or 2 to exit the program");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
               TitleScreen();
            }
        }

        public void displayProfit(double profit)
        {
            Console.WriteLine("you made $" + profit + " today");
        }
    }
}
