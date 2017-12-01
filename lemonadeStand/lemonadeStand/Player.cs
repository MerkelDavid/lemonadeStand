using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Player
    {
        private string name;
        Inventory playerInventory = new Inventory();
        Wallet wallet = new Wallet(20);

        public void setName (string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public Inventory getInventory()
        {
            return playerInventory;
        }

        public void purchaseCups (int userChoice)
        {
            if (userChoice == 1)
            {
                if (wallet.getMoney() > .76)
                {
                    playerInventory.addCups(25);
                    wallet.subtractMoney(.76);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
            else if (userChoice == 2)
            {
                if (wallet.getMoney() > 1.62)
                {
                    playerInventory.addCups(50);
                    wallet.subtractMoney(1.62);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
            if (userChoice == 3)
            {
                if (wallet.getMoney() > 2.84)
                {
                    playerInventory.addCups(100);
                    wallet.subtractMoney(2.84);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }

        }

        public void purchaseLemons(int userChoice)
        {
            if (userChoice == 1)
            {
                if (wallet.getMoney() > .73)
                {
                    playerInventory.addLemons(10);
                    wallet.subtractMoney(.73);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
            else if (userChoice == 2)
            {
                if (wallet.getMoney() > 2.22)
                {
                    playerInventory.addLemons(30);
                    wallet.subtractMoney(2.22);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
            if (userChoice == 3)
            {
                if (wallet.getMoney() > 4.48)
                {
                    playerInventory.addLemons(75);
                    wallet.subtractMoney(4.48);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
        }
        public void purchaseSugar(int userChoice)
        {
            if (userChoice == 1)
            {
                if (wallet.getMoney() > .65)
                {
                    playerInventory.addSugar(8);
                    wallet.subtractMoney(.65);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
            else if (userChoice == 2)
            {
                if (wallet.getMoney() > 1.74)
                {
                    playerInventory.addSugar(20);
                    wallet.subtractMoney(1.74);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
            if (userChoice == 3)
            {
                if (wallet.getMoney() > 3.37)
                {
                    playerInventory.addSugar(48);
                    wallet.subtractMoney(3.37);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
        }
        public void purchaseIceCubes(int userChoice)
        {
            if (userChoice == 1)
            {
                if (wallet.getMoney() > .78)
                {
                    playerInventory.addIceCubes(100);
                    wallet.subtractMoney(.78);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
            else if (userChoice == 2)
            {
                if (wallet.getMoney() > 2.12)
                {
                    playerInventory.addIceCubes(250);
                    wallet.subtractMoney(2.12);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
            if (userChoice == 3)
            {
                if (wallet.getMoney() > 3.72)
                {
                    playerInventory.addIceCubes(500);
                    wallet.subtractMoney(3.72);
                    Console.Clear();
                    Console.WriteLine("Your purchase was successfull.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You do not have sufficient funds.\n");
                }
            }
        }

        public void decrementIngredients(Lemonade recipe)
        {
            playerInventory.subtractIceCubes(recipe.getIceCubes());
            playerInventory.subtractLemons(recipe.getLemons());
            playerInventory.subtractSugar(recipe.getSugar());
        }

        public int clearLemonBasket()
        {
            return playerInventory.clearBasket();
        }

        public void meltIceCubes()
        {
            playerInventory.setIceCubes(0);
        }

        public void clearSugar()
        {
            playerInventory.setSugar(0);
        }

        public void addMoney(double amount)
        {
            wallet.addMoney(amount);
        }

        public double getMoney()
        {
            return wallet.getMoney();
        }
    }
}
