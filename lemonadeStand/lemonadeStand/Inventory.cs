using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Inventory
    {
        private List<Lemon> lemonBasket;
        private int numOfIceCubes;
        private int numOfCups;
        private int numOfSugar;

        public Inventory()
        {
            numOfCups = 0;
            numOfIceCubes = 0;
            numOfSugar = 0;
        }

        public int getCups()
        {
            return numOfCups;
        }

        public int getIceCubes()
        {
            return numOfIceCubes;
        }

        public int getSugar()
        {
            return numOfSugar;
        }

        public int getNumOfLemons()
        {
            return lemonBasket.Count;
        }

        public void addCups(int count)
        {
            numOfCups += count;
        }

        public void addSugar(int count)
        {
            numOfSugar += count;
        }

        public void addIceCubes(int count)
        {
            numOfIceCubes += count;
        }

        public void addLemons(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Lemon newLemon = new Lemon();
                lemonBasket.Add(newLemon);
            }
        }

        public void clearBasket()
        {
            for(int i=0; i<lemonBasket.Count; i++)
            {
                if (lemonBasket[i].IsSpoiled())
                {
                    lemonBasket.RemoveAt(i);
                }
            }
        }

    }
}
