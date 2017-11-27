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
    }

}
