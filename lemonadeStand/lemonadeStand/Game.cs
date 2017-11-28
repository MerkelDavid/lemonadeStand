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
            Weather forcast = generateWeather();
            inventoryScreen(null);
            Lemonade recipe = UIInstance.lemonadeCreation();
            simulateDay(recipe,forcast);
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
                case 6:
                    //quit
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
            if (int.TryParse(userChoice, out n) && n > 0 && n < 4)
            {
                return true;
            }
            else return false;
        }

        public void simulateDay(Lemonade recipe,Weather forcast)
        {
            int numberOfCustomers = generateNumberOfCustomers(recipe, forcast);
        }

    }
}