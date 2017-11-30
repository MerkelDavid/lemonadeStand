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
        private UI UIInstance = new UI();
        private Player player1 = new Player();
        private Random randomSeed = new Random();

        public Game(int numDays)
        {
            this.numDays = numDays;
        }

        public Weather generateWeather()
        {
            return new Weather();
        }

        public void GameLoop()
        {
            player1.setName(UIInstance.getUserName());
            for (int i = 0; i < numDays; i++)
            {
                Weather forcast = generateWeather();
                inventoryScreen(forcast);
                Lemonade recipe = UIInstance.lemonadeCreation();
                double profit = simulateDay(recipe, forcast);
                endOfDay(profit);
            }
            UIInstance.endScreen(player1);
        }

        public Weather inventoryScreen(Weather forcast)
        {
            UIInstance.displayPurchaseScreen(player1, forcast);
            int inventoryInput = Convert.ToInt32(Console.ReadLine());
            if (UIInstance.isValidInventoryInput(inventoryInput))
            {
                inventorySwitch(inventoryInput,forcast); 
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid input");
                inventoryScreen(forcast);
            }
            return null;
        }

        public void inventorySwitch(int inventoryInput,Weather forcast)
        {

            switch (inventoryInput)
            {
                case 1:
                    cupsOptions();
                    inventoryScreen(forcast);
                    break;
                case 2:
                    lemonsOptions();
                    inventoryScreen(forcast);
                    break;
                case 3:
                    sugarOptions();
                    inventoryScreen(forcast);
                    break;
                case 4:
                    iceOptions();
                    inventoryScreen(forcast);
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        public void cupsOptions()
        {
            Console.Clear();
            UIInstance.cupsScreen(player1);
            string userChoice = Console.ReadLine();
            if (userChoiceValidation(userChoice))
            {
                player1.purchaseCups(Convert.ToInt32(userChoice));
            }
            else
            {
                cupsOptions();
            }
        }

        public void lemonsOptions()
        {
            Console.Clear();
            UIInstance.lemonScreen(player1);
            string userChoice = Console.ReadLine();
            if (userChoiceValidation(userChoice))
            {
                player1.purchaseLemons(Convert.ToInt32(userChoice));
            }
            else
            {
                lemonsOptions();
            }
        }

        public void sugarOptions()
        {
            Console.Clear();
            UIInstance.sugarScreen(player1);
            string userChoice = Console.ReadLine();
            if (userChoiceValidation(userChoice))
            {
                player1.purchaseSugar(Convert.ToInt32(userChoice));
            }
            else
            {
                sugarOptions();
            }
        }

        public void iceOptions()
        {
            Console.Clear();
            UIInstance.iceScreen(player1);
            string userChoice = Console.ReadLine();
            if (userChoiceValidation(userChoice))
            {
                player1.purchaseIceCubes(Convert.ToInt32(userChoice));
            }
            else
            {
                iceOptions();
            }
        }

        public bool userChoiceValidation(string userChoice)
        {
            int n;
            if (int.TryParse(userChoice, out n) && n > 0 && n < 5)
            {
                return true;
            }
            else return false;
        }

        //to do check for valid ingredients
        public double simulateDay(Lemonade pitcher,Weather forcast)
        {
            Inventory playerInventory = player1.getInventory();
            Customers customerInstance = new Customers(pitcher,forcast);
            int numberOfCustomers = generateNumberOfCustomers(pitcher, forcast);
            double profit = 0;
            if (!playerInventory.enoughIngredients(pitcher))
            {
                return 0;
            }
            player1.decrementIngredients(pitcher);
            for (int i = 0; i < numberOfCustomers; i++){
                Customers currentCustomer = new Customers(pitcher,forcast);

                if (currentCustomer.isBuying() && playerInventory.areEnoughCups())
                {
                    pitcher.decrementCups();
                    playerInventory.decrementCups();
                    player1.addMoney(pitcher.getPrice());
                    profit += pitcher.getPrice();

                    if (pitcher.isEmpty())
                    {
                        if (playerInventory.enoughIngredients(pitcher))
                        {
                            player1.decrementIngredients(pitcher);
                            pitcher = new Lemonade(pitcher.getLemons(), pitcher.getSugar(), pitcher.getIceCubes(), pitcher.getPrice());
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return profit;
        }
        public int generateNumberOfCustomers(Lemonade recipe, Weather forcast)
        {
            int numberOfCustomers = 10;

            if (forcast.getWeather() == "sunny")
            {
                numberOfCustomers = randomSeed.Next(50, 75);
            }
            else if(forcast.getWeather() == "cloudy")
            {
                numberOfCustomers = randomSeed.Next(25, 50);
            }
            else if(forcast.getWeather() == "rainy")
            {
                numberOfCustomers = randomSeed.Next(11, 25);
            }
            return numberOfCustomers;
       }

        public void endOfDay(double profit)
        {
            Console.Clear();
            UIInstance.displayProfit(profit);
            spoilLemons();
            meltIceCubes();
            checkForFlies();

            Console.WriteLine("press any button to continue.");
            Console.ReadKey();
        }

        public void spoilLemons()
        {
            int spoilCount = 0;
            Inventory playerInventory = player1.getInventory();
            playerInventory.spoilLemons();
            spoilCount += player1.clearLemonBasket();
            Console.WriteLine(spoilCount + " lemons have spoiled");
        }

        public void meltIceCubes()
        {
            player1.meltIceCubes();
            Console.WriteLine("Your ice cubes have melted");
        }

        public void checkForFlies()
        {
            int chanceForFlies = randomSeed.Next(1, 4);
            if (chanceForFlies == 1)
            {
                player1.clearSugar();
                Console.WriteLine("flies have eaten all of your sugar!");
            }
        }

    }
}