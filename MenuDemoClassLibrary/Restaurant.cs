using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemoClassLibrary
{
    public class Restaurant
    {
        private int _restaurantID = -1;
        public int RestaurantID
        {
            get { return _restaurantID; }
            set { _restaurantID = value; }
        }

        private string _restaurantName;
        public string RestaurantName
        {
            get { return _restaurantName; }
            set { _restaurantName = value; }
        }

        private string _restaurantPhone;
        public string RestaurantPhone
        {
            get { return _restaurantPhone; }
            set { _restaurantPhone = value; }
        }

        private string _restaurantAddress;
        public string RestaurantAddress
        {
            get { return _restaurantAddress; }
            set { _restaurantAddress = value; }
        }
        
        private bool _restaurantOperational = false;
        public bool RestaurantOperational
        {
            get { return _restaurantOperational; }
            set { _restaurantOperational = value; }
        }

        private List<Menu> _menusList = new List<Menu>();
        public List<Menu> MenusList
        {
            get { return _menusList; }
            set { _menusList = value; }
        }




        public Restaurant()
        {

        }

        public Restaurant(string RestaurantName, string RestaurantPhone, string RestaurantAddress)
        {
            this.RestaurantName = RestaurantName;
            this.RestaurantPhone = RestaurantPhone;
            this.RestaurantAddress = RestaurantAddress;
        }
    } 
}
