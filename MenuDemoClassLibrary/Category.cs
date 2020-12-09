using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemoClassLibrary
{
    public class Category
    {
        private int _categoryID = -1;

        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }

        private int _categoryOrder = -1;
        public int CategoryOrder
        {
            get { return _categoryOrder; }
            set { _categoryOrder = value; }
        }

        private string _categoryName;
        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        private List<Subcategory> _subcategoriesList = new List<Subcategory>();
        public List<Subcategory> SubcategoriesList
        {
            get { return _subcategoriesList; }
            set { _subcategoriesList = value; }
        }

        private List<FoodItem> _foodItemsList = new List<FoodItem>();
        public List<FoodItem> FoodItemsList
        {
            get { return _foodItemsList; }
            set { _foodItemsList = value; }
        }



        public Category()
        {

        }

        public Category(string CategoryName)
        {
            this.CategoryName = CategoryName;
        }
    }
}
