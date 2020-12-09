using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemoClassLibrary
{
    public class Menu
    {
        private int _menuID = -1;

        public int MenuID
        {
            get { return _menuID; }
            set { _menuID = value; }
        }

        private int _menuOrder = -1;
        public int MenuOrder
        {
            get { return _menuOrder; }
            set { _menuOrder = value; }
        }

        private string _menuName;
        public string MenuName
        {
            get { return _menuName; }
            set { _menuName = value; }
        }

        private List<Category> _categoriesList = new List<Category>();
        public List<Category> CategoriesList
        {
            get { return _categoriesList; }
            set { _categoriesList = value; }
        }



        public Menu()
        {

        }

        public Menu(string MenuName)
        {
            this.MenuName = MenuName;
        }
    }
}
