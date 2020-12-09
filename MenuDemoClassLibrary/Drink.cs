using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemoClassLibrary
{
    public class Drink : FoodItem
    {
        private float _drinkSize;

        public float DrinkSize
        {
            get { return _drinkSize; }
            set { _drinkSize = value; }
        }

        private float _drinkAlcoholContent = 0;
        public float DrinkAlcoholContent
        {
            get { return _drinkAlcoholContent; }
            set { _drinkAlcoholContent = value; }
        }



        public Drink()
        {

        }

        public Drink(string FoodName, float FoodPrice, string FoodDescription, float DrinkSize, float DrinkAlcoholContent)
        {
            this.FoodItemName = FoodName;
            this.FoodItemPrice = FoodPrice;
            this.FoodItemDescription = FoodDescription;
            this.DrinkSize = DrinkSize;
            this.DrinkAlcoholContent = DrinkAlcoholContent;
        }
    }
}
