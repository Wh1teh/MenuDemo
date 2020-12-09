using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemoClassLibrary
{
    public class FoodItem
    {
        private int _foodItemID = -1;

        public int FoodItemID
        {
            get { return _foodItemID; }
            set { _foodItemID = value; }
        }

        private int _foodItemOrder = -1;
        public int FoodItemOrder
        {
            get { return _foodItemOrder; }
            set { _foodItemOrder = value; }
        }

        private string _foodItemName;
        public string FoodItemName
        {
            get { return _foodItemName; }
            set { _foodItemName = value; }
        }

        private float _foodItemPrice = -1;
        public float FoodItemPrice
        {
            get { return _foodItemPrice; }
            set { _foodItemPrice = value; }
        }

        private string _foodItemDescription;
        public string FoodItemDescription
        {
            get { return _foodItemDescription; }
            set { _foodItemDescription = value; }
        }

        private int _foodItemType;

        public int FoodItemType
        {
            get { return _foodItemType; }
            set { _foodItemType = value; }
        }

        private int _foodItemDrinkSize;

        public int FoodItemDrinkSize
        {
            get { return _foodItemDrinkSize; }
            set { _foodItemDrinkSize = value; }
        }

        private int _foodItemAlcohol;

        public int FoodItemAlcohol
        {
            get { return _foodItemAlcohol; }
            set { _foodItemAlcohol = value; }
        }




        private List<Allergen> _allergensList = new List<Allergen>();
        public List<Allergen> AllergensList
        {
            get { return _allergensList; }
            set { _allergensList = value; }
        }



        public FoodItem()
        {

        }


        public FoodItem(string FoodName, float FoodPrice, string FoodDescription)
        {
            this.FoodItemName = FoodName;
            this.FoodItemPrice = FoodPrice;
            this.FoodItemDescription = FoodDescription;
        }
    }
}
