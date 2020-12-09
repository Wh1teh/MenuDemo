using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemoClassLibrary
{
    public class Subcategory
    {
        private int _subcategoryID = -1;

        public int SubcategoryID
        {
            get { return _subcategoryID; }
            set { _subcategoryID = value; }
        }

        private int _subcategoryOrder = -1;
        public int SubcategoryOrder
        {
            get { return _subcategoryOrder; }
            set { _subcategoryOrder = value; }
        }

        private string _subcategoryName;
        public string SubcategoryName
        {
            get { return _subcategoryName; }
            set { _subcategoryName = value; }
        }

        private List<FoodItem> _foodItemsList = new List<FoodItem>();
        public List<FoodItem> FoodItemsList
        {
            get { return _foodItemsList; }
            set { _foodItemsList = value; }
        }



        public Subcategory()
        {

        }

        public Subcategory(string SubcategoryName)
        {
            this.SubcategoryName = SubcategoryName;
        }
    }
}
