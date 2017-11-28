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
        private double money;

        public Player()
        {
            name = "David";
            money = 20;
        }

        public double getMoney()
        {
            return money;
        }

        public string getName()
        {
            return name;
        }

        public Inventory getInventory()
        {
            return playerInventory;
        }

        public void subtractMoney(double price)
        {
            money -= price;
        }

        public void addMoney(double price)
        {
            money += price;
        }

        public void purchaseCups (int userChoice)
        {
            if (userChoice == 1)
            {
                if (money > .76)
                {
                    playerInventory.addCups(25);
                    subtractMoney(.76);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
            else if (userChoice == 2)
            {
                if (money > 1.62)
                {
                    playerInventory.addCups(50);
                    subtractMoney(1.62);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
            if (userChoice == 3)
            {
                if (money > 2.84)
                {
                    playerInventory.addCups(100);
                    subtractMoney(2.84);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }

        }

        public void purchaseLemons(int userChoice)
        {
            if (userChoice == 1)
            {
                if (money > .73)
                {
                    playerInventory.addLemons(10);
                    subtractMoney(.73);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
            else if (userChoice == 2)
            {
                if (money > 2.22)
                {
                    playerInventory.addLemons(30);
                    subtractMoney(2.22);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
            if (userChoice == 3)
            {
                if (money > 4.48)
                {
                    playerInventory.addLemons(75);
                    subtractMoney(4.48);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
        }
        public void purchaseSugar(int userChoice)
        {
            Console.WriteLine("1. 8 cups for $0.65");
            Console.WriteLine("2. 20 cups for $1.74");
            Console.WriteLine("1. 48 cups for $3.37");
            if (userChoice == 1)
            {
                if (money > .65)
                {
                    playerInventory.addSugar(8);
                    subtractMoney(.65);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
            else if (userChoice == 2)
            {
                if (money > 1.74)
                {
                    playerInventory.addSugar(30);
                    subtractMoney(1.74);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
            if (userChoice == 3)
            {
                if (money > 3.37)
                {
                    playerInventory.addSugar(48);
                    subtractMoney(3.37);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
        }
        public void purchaseIceCubes(int userChoice)
        {
            Console.WriteLine("1. 100 ice cubes for $0.78");
            Console.WriteLine("2. 250 ice cubes for $2.12");
            Console.WriteLine("1. 500 ice cubes for $3.72");
            if (userChoice == 1)
            {
                if (money > .78)
                {
                    playerInventory.addIceCubes(100);
                    subtractMoney(.78);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
            else if (userChoice == 2)
            {
                if (money > 2.12)
                {
                    playerInventory.addIceCubes(250);
                    subtractMoney(2.12);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
            if (userChoice == 3)
            {
                if (money > 3.72)
                {
                    playerInventory.addSugar(500);
                    subtractMoney(3.72);
                    Console.WriteLine("Your purchase was successfull.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds.");
                }
            }
        }
    }
}
