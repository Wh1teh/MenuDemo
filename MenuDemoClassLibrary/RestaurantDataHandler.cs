using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace MenuDemoClassLibrary
{
    public class RestaurantDataHandler:DataAccess
    {
        
        public static Object GetTest()
        {
            string str = DataAccess.CnnVal(DataAccess.currentDBName);

            using (IDbConnection connection = new SqlConnection(str))
            {
                var toReturn = connection.QueryFirst<Object>("SELECT * FROM dbo.FoodItem");
                return toReturn;
            }
        }

        public static List<FoodItem> GetAllDishesFromDB()
        {
            string str = DataAccess.CnnVal(DataAccess.currentDBName);

            using (IDbConnection connection = new SqlConnection(str))
            {
                var toReturn = connection.Query<FoodItem>("SELECT * FROM FoodItem").ToList();
                return toReturn;
            }
        }

        //prints
        public void PrintRestaurant()
        {

        }

        public void PrintEveryRestaurant()
        {

        }

        public void PrintMenu()
        {

        }

        public void PrintEveryMenu()
        {

        }


        public void PrintCategory()
        {

        }

        public void PrintEveryCategory()
        {

        }

        public void PrintSubcategory()
        {

        }

        public void PrintEverySubcategory()
        {

        }

        public void PrintFoodItem()
        {

        }

        public void PrintEveryFoodItem()
        {

        }



        //restaurant data handling
        private static Restaurant CreateRestaurant() //create restaurant
        {
            Console.Write("Restaurant name: "); var restaurantName = Console.ReadLine();
            Console.Write("Restaurant phone: "); var restaurantPhone = Console.ReadLine();
            Console.Write("Restaurant address: "); var restaurantAddress = Console.ReadLine();

            var restaurant = new Restaurant(restaurantName, restaurantPhone, restaurantAddress);

            return restaurant;
        }

        private int _lastGivenRestaurantID = 0;

        private List<Restaurant> _restaurants = new List<Restaurant>();

        public void AddNewRestaurant()
        {
            Restaurant restaurant = CreateRestaurant();

            restaurant.RestaurantID = _lastGivenRestaurantID;
            _lastGivenRestaurantID++;

            _restaurants.Add(restaurant);
        }

        public void EditRestaurant() // replaces old restaurant with new info but same ID
        {
            int userGivenID = RestaurantMenuFunctions.AskIDFromUser();

            var restaurantToEdit = _restaurants.Single(n => n.RestaurantID == userGivenID);

            Console.WriteLine(restaurantToEdit.RestaurantName);

            Restaurant replacingRestaurant = CreateRestaurant();  

            _restaurants.Remove(restaurantToEdit);

            replacingRestaurant.RestaurantID = userGivenID;
            _restaurants.Add(replacingRestaurant);
        }

        public void DeleteRestaurantPermanently() //delete restaurant based on id
        {
            int userGivenID = RestaurantMenuFunctions.AskIDFromUser();

            var restaurantToRemove = _restaurants.Single(n => n.RestaurantID == userGivenID);

            _restaurants.Remove(restaurantToRemove);
        }

        //menu data handling

        private Menu CreateMenu()
        {
            Console.Write("Menu name: "); var menuName = Console.ReadLine();

            var menu = new Menu(menuName);

            return menu;
        }

        //category data handling
        private Category CreateCategory()
        {
            Console.Write("Category name: "); var categoryName = Console.ReadLine();

            var category = new Category(categoryName);

            return category;
        }

        //subcategory data handling
        private Subcategory CreateSubcategory()
        {
            Console.Write("Subcategory name: "); var subcategoryName = Console.ReadLine();

            var subcategory = new Subcategory(subcategoryName);

            return subcategory;
        }

        //food item data handling
        private FoodItem CreateFoodItem()
        {
            Console.Write("Food name: "); var foodName = Console.ReadLine();
            Console.Write("Food price: "); var foodPrice = float.Parse(Console.ReadLine());
            Console.Write("Food description: "); var foodDescription = Console.ReadLine();

            var foodItem = new FoodItem(foodName, foodPrice, foodDescription);

            return foodItem;
        }

        //drink data handling
        private Drink CreateDrink()
        {
            Console.Write("Drink name: "); var drinkName = Console.ReadLine();
            Console.Write("Drink price: "); var drinkPrice = float.Parse(Console.ReadLine());
            Console.Write("Drink description: "); var drinkDescription = Console.ReadLine();
            Console.Write("Drink size: "); var drinkSize = float.Parse(Console.ReadLine());
            Console.Write("Alcohol content: "); var drinkAlcoholContent = float.Parse(Console.ReadLine());

            var drink = new Drink(drinkName, drinkPrice, drinkDescription, drinkSize, drinkAlcoholContent);

            return drink;
        }








        //test data
        public void InitTestData() //negative ids reserved for debugging
        {
            var rest1 = new Restaurant();
            var rest1Menu1 = new Menu();
            var rest1Menu2 = new Menu();
            var rest1Category1 = new Category();
            var rest1Category2 = new Category();
            var rest1Category3 = new Category();
            var rest1Category4 = new Category();
            var rest1Subcategory1 = new Subcategory();
            var rest1Subcategory2 = new Subcategory();
            var rest1Food1 = new FoodItem();
            var rest1Food2 = new FoodItem();
            var rest1Food3 = new FoodItem();
            var rest1Food4 = new FoodItem();
            var rest1Food5 = new FoodItem();
            var rest1Food6 = new FoodItem();
            var rest1Food7 = new FoodItem();
            var rest1Food8 = new FoodItem();
            var rest1Drink1 = new Drink();
            var rest1Drink2 = new Drink();
            var rest1Drink3 = new Drink();
            //var allergenLactose = new Allergen();


            rest1.RestaurantID = -2;
            rest1.RestaurantName = "Test Restaurant";
            rest1.RestaurantPhone = "401119922";
            rest1.RestaurantAddress = "Test Road 123 A";
            rest1.RestaurantOperational = true;



            rest1Menu1.MenuID = -2;
            rest1Menu1.MenuOrder = 1;
            rest1Menu1.MenuName = "Test Menu";

            rest1Menu2.MenuID = -3;
            rest1Menu2.MenuOrder = 2;
            rest1Menu2.MenuName = "Test Alternate Menu";



            rest1Category1.CategoryID = -2;
            rest1Category1.CategoryOrder = 1;
            rest1Category1.CategoryName = "Appetizers";

            rest1Category2.CategoryID = -3;
            rest1Category2.CategoryOrder = 2;
            rest1Category2.CategoryName = "Main Course";

            rest1Category3.CategoryID = -4;
            rest1Category3.CategoryOrder = 3;
            rest1Category3.CategoryName = "Desserts";

            rest1Category4.CategoryID = -5;
            rest1Category4.CategoryOrder = 4;
            rest1Category4.CategoryName = "Drinks";



            rest1Subcategory1.SubcategoryID = -2;
            rest1Subcategory1.SubcategoryOrder = 1;
            rest1Subcategory1.SubcategoryName = "Borgars";

            rest1Subcategory2.SubcategoryID = -3;
            rest1Subcategory2.SubcategoryOrder = 2;
            rest1Subcategory2.SubcategoryName = "Seafood";



            //var r = Allergen.allergenChars[""];

            rest1Food1.FoodItemID = -2;
            rest1Food1.FoodItemOrder = 1; //öö tää ei varmaa toimi kätevästi näin
            rest1Food1.FoodItemName = "Makkaraperunat";
            rest1Food1.FoodItemPrice = 5.5f;
            //rest1Food1.FoodAlcoholContent = 0;
            rest1Food1.FoodItemDescription = "HK:n sinistä ja suomalaisia pottuja";
            //allergeenit pitää miettiä

            rest1Food2.FoodItemID = -3;
            rest1Food2.FoodItemOrder = 2;
            rest1Food2.FoodItemName = "Nakkikeitto";
            rest1Food2.FoodItemPrice = 6.5f;
            //rest1Food2.FoodAlcoholContent = 0;
            rest1Food2.FoodItemDescription = "HK:n sinistä ja suomalaisia pottuja";

            rest1Food3.FoodItemID = -4;
            rest1Food3.FoodItemOrder = 4;
            rest1Food3.FoodItemName = "Kalasalaatti";
            rest1Food3.FoodItemPrice = 8.5f;
            //rest1Food3.FoodAlcoholContent = 0;
            rest1Food3.FoodItemDescription = "Lohta ja ruukkusalaattia";

            rest1Food4.FoodItemID = -5;
            rest1Food4.FoodItemOrder = 5;
            rest1Food4.FoodItemName = "Kebab borgar";
            rest1Food4.FoodItemPrice = 9.5f;
            //rest1Food4.FoodAlcoholContent = 0;
            rest1Food4.FoodItemDescription = "Burg";

            rest1Food5.FoodItemID = -6;
            rest1Food5.FoodItemOrder = 6;
            rest1Food5.FoodItemName = "Uunimakkara borgar";
            rest1Food5.FoodItemPrice = 16.5f;
            //rest1Food5.FoodAlcoholContent = 0;
            rest1Food5.FoodItemDescription = "HK:n sinistä ja suomalaisia pottuja";

            rest1Food6.FoodItemID = -7;
            rest1Food6.FoodItemOrder = 1;
            rest1Food6.FoodItemName = "Jätski";
            rest1Food6.FoodItemPrice = 5.5f;
            rest1Food6.FoodItemDescription = "Vanilja jätskiä";

            rest1Food7.FoodItemID = -8;
            rest1Food7.FoodItemOrder = 2;
            rest1Food7.FoodItemName = "Sokerimakkara";
            rest1Food7.FoodItemPrice = 10.5f;
            rest1Food7.FoodItemDescription = "HK:n sinistä ja suomalaisia pottuja";

            rest1Food8.FoodItemID = -9;
            rest1Food8.FoodItemOrder = 3;
            rest1Food8.FoodItemName = "Uunipannaani";
            rest1Food8.FoodItemPrice = 6.5f;
            rest1Food8.FoodItemDescription = "Makea bansku ota tai jätä";

            rest1Drink1.FoodItemID = -10;
            rest1Drink1.FoodItemOrder = 1;
            rest1Drink1.FoodItemName = "Blörö";
            rest1Drink1.FoodItemPrice = 4;
            //rest1Drink1.FoodAlcoholContent = 90;
            rest1Drink1.FoodItemDescription = "Kahvia ja pirtua";
            rest1Drink1.DrinkSize = 0.4f;

            rest1Drink2.FoodItemID = -11;
            rest1Drink2.FoodItemOrder = 2;
            rest1Drink2.FoodItemName = "Limppari";
            rest1Drink2.FoodItemPrice = 3;
            //rest1Drink2.FoodAlcoholContent = 0;
            rest1Drink2.FoodItemDescription = "Bränditön hiilihapotettu limppari";
            rest1Drink2.DrinkSize = 0.5f;

            rest1Drink3.FoodItemID = -12;
            rest1Drink3.FoodItemOrder = 3;
            rest1Drink3.FoodItemName = "Kalja olut";
            rest1Drink3.FoodItemPrice = 7;
            //rest1Drink3.FoodAlcoholContent = 5;
            rest1Drink3.FoodItemDescription = "Tuoppi kaljaa";
            rest1Drink3.DrinkSize = 0.7f;



            //listat
            _restaurants.Add(rest1);

            rest1Category1.FoodItemsList.Add(rest1Food3);

            rest1Category2.FoodItemsList.Add(rest1Food1);
            rest1Category2.FoodItemsList.Add(rest1Food2);

            rest1Category3.FoodItemsList.Add(rest1Food6);
            rest1Category3.FoodItemsList.Add(rest1Food7);
            rest1Category3.FoodItemsList.Add(rest1Food8);

            rest1Category4.FoodItemsList.Add(rest1Drink1);
            rest1Category4.FoodItemsList.Add(rest1Drink2);
            rest1Category4.FoodItemsList.Add(rest1Drink3);

            rest1Subcategory1.FoodItemsList.Add(rest1Food4);
            rest1Subcategory1.FoodItemsList.Add(rest1Food5);



            rest1Category2.SubcategoriesList.Add(rest1Subcategory1);
            rest1Category2.SubcategoriesList.Add(rest1Subcategory2);

            rest1Menu1.CategoriesList.Add(rest1Category1);
            rest1Menu1.CategoriesList.Add(rest1Category2);
            rest1Menu1.CategoriesList.Add(rest1Category3);
            rest1Menu1.CategoriesList.Add(rest1Category4);

            rest1.MenusList.Add(rest1Menu1);
            rest1.MenusList.Add(rest1Menu2);
        }



        public void TestPrintEveryRestaurant() //ids are for debug purposes only
        {
            foreach (var restaurant in _restaurants)
            {
                Console.WriteLine($"\n{restaurant.RestaurantName}, id {restaurant.RestaurantID}");

                foreach (var menu in restaurant.MenusList)
                {
                    Console.WriteLine($"\n-{menu.MenuName}, id {menu.MenuID}");

                    foreach (var category in menu.CategoriesList)
                    {
                        Console.WriteLine($"\n--{category.CategoryName}, id {category.CategoryID}");

                        foreach (var foodItem in category.FoodItemsList)
                        {
                            Console.WriteLine($"\n----{foodItem.FoodItemName} - {foodItem.FoodItemPrice}" +
                                $"\n    {foodItem.FoodItemDescription}, id {foodItem.FoodItemID}");

                            //foreach allergen
                        }

                        foreach (var subcategory in category.SubcategoriesList)
                        {
                            Console.WriteLine($"\n---{subcategory.SubcategoryName}, id {subcategory.SubcategoryID}");

                            foreach (var foodItem in subcategory.FoodItemsList)
                            {
                                Console.WriteLine($"\n-----{foodItem.FoodItemName} - {foodItem.FoodItemPrice}" +
                                $"\n     {foodItem.FoodItemDescription}, id {foodItem.FoodItemID}");

                                //foreach allergen
                            }
                        }
                    }
                }
                Console.WriteLine("//restaurant end\n\n\n");
            }
        }





        public void TestPrintEveryRestaurantFromDB()
        {
            string str = DataAccess.CnnVal(DataAccess.currentDBName);

            using (IDbConnection connection = new SqlConnection(str))
            {
                foreach (var restaurant in connection.Query<Restaurant>("SELECT * FROM dbo.Restaurant"))
                {
                    Console.WriteLine($"testing... {restaurant.RestaurantName}");
                }
            }
        }


        public static List<FoodItem> GetFoodItemsInCategory(int id)
        {
            string str = DataAccess.CnnVal(DataAccess.currentDBName);

            using (IDbConnection connection = new SqlConnection(str))
            {
                var foodItem = connection.Query<FoodItem>($"SELECT * FROM dbo.FoodItem WHERE ID IN (SELECT itemID FROM dbo.CategoryFood WHERE inID={id})").ToList();
                return foodItem;
            }
        }

        public void TEST1()
        {
            List<FoodItem> restaurant = GetFoodItemsInCategory(1);

            foreach (var item in restaurant)
            {
                Console.WriteLine(item.FoodItemName);
            }
        }


        public List<Object> GetXInY(int id, string itemX, string inY)
        {
            string str = DataAccess.CnnVal(DataAccess.currentDBName);

            using (IDbConnection connection = new SqlConnection(str))
            {
                var returnThis = connection.Query<Object>($"SELECT * FROM {itemX} WHERE ID IN (SELECT itemID FROM {inY} WHERE inID={id})").ToList();
                return returnThis;
            }
        }

        public void TEST2()
        {
            List<FoodItem> restaurant = GetXInY(1, "FoodItem", "CategoryFood");

            foreach (var item in restaurant)
            {
                Console.WriteLine(item.FoodItemName);
            }
        }




        public void TestPrintEverythingFromDB()
        {
            string str = DataAccess.CnnVal(DataAccess.currentDBName);

            using (IDbConnection connection = new SqlConnection(str))
            {
                foreach (var restaurant in connection.Query<Restaurant>("SELECT * FROM dbo.Restaurant"))
                {
                    Console.WriteLine($". {restaurant.RestaurantName}");

                    foreach (var menu in connection.Query<Menu>($"SELECT * FROM dbo.Menu WHERE MenuID IN (SELECT MenuID FROM dbo.RestaurantMenu WHERE RestaurantID={restaurant.RestaurantID})"))
                    {
                        Console.WriteLine($".. {menu.MenuName}");

                        foreach (var category in connection.Query<Category>($"SELECT * FROM dbo.Category WHERE CategoryID IN (SELECT CategoryID FROM dbo.MenuCategory WHERE MenuID={menu.MenuID})"))
                        {
                            Console.WriteLine($"... {category.CategoryName}");

                            foreach (var foodItem in connection.Query<FoodItem>($"SELECT * FROM dbo.FoodItem WHERE FoodItemID IN (SELECT FoodItemID FROM dbo.CategoryFood WHERE categoryID={category.CategoryID})"))
                            {
                                Console.WriteLine($"..... {foodItem.FoodItemName}");
                            }

                            foreach (var drink in connection.Query<Drink>($"SELECT * FROM dbo.Drink WHERE FoodItemID IN (SELECT FoodItemID FROM dbo.CategoryDrink WHERE categoryID={category.CategoryID})"))
                            {
                                Console.WriteLine($"..... {drink.FoodItemName}");
                            }

                            foreach (var subcategory in connection.Query<Subcategory>($"SELECT * FROM dbo.Subcategory WHERE SubcategoryID IN (SELECT SubcategoryID FROM dbo.CategorySubcategory WHERE categoryID={category.CategoryID})"))
                            {
                                Console.WriteLine($".... {subcategory.SubcategoryName}");

                                foreach (var foodItem in connection.Query<FoodItem>($"SELECT * FROM dbo.FoodItem WHERE FoodItemID IN (SELECT FoodItemID FROM dbo.SubcategoryFood WHERE subcategoryID={subcategory.SubcategoryID})"))
                                {
                                    Console.WriteLine($"..... {foodItem.FoodItemName}");
                                }

                                foreach (var drink in connection.Query<Drink>($"SELECT * FROM dbo.Drink WHERE FoodItemID IN (SELECT FoodItemID FROM dbo.SubcategoryDrink WHERE subcategoryID={subcategory.SubcategoryID})"))
                                {
                                    Console.WriteLine($"..... {drink.FoodItemName}");
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
