using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubiquityTest.Core.Classes
{
    public sealed class Player
    {
        #region properties

        private string name;
        private int kablammoCount = 0;
        private List<Food> lstFood = new List<Food>();

        //fields encapsulation
        public string Name { get => name; set => name = value; }
        public int KablammoCount { get => kablammoCount; } //readonly

        //a read only getter that will return only the available food (IsConsumed = false)
        public List<Food> LstFood { get => (from f in lstFood where f.IsConsumed == false select f).ToList(); }

        #endregion

        #region methods

        #region Thread Safe Singleton implementation using Double Check Locking

        Player()
        {

        }
        private static readonly object padlock = new object();
        private static Player instance = null;
        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Player();
                        }
                    }
                }
                return instance;
            }
        }


        #endregion

        public void IncreaseKablammoCount(int amount) => this.kablammoCount += amount;
        public void DecreaseKablammoCount(int amount) => this.kablammoCount -= amount;

        /// <summary>
        /// funnction to buy a new food item and add it to the list of food
        /// </summary>
        /// <param name="food"></param>
        public bool BuyFood(Food food)
        {
            if (food.Cost > this.kablammoCount)
                return false;
            
            //decrease kablammo count
            DecreaseKablammoCount(food.Cost);

            AppendFood(food);

            return true;
        }

        /// <summary>
        /// function that appends a food item to the list of player food
        /// </summary>
        /// <param name="food"></param>
        public void AppendFood(Food food) {
            //append the food item to the list of food
            this.lstFood.Add(food);
        }

        /// <summary>
        /// Reset the properties of the player
        /// </summary>
        public void Reset() {
            this.kablammoCount = 0;
            this.lstFood = new List<Food>();
        }

        #endregion
    }
}
