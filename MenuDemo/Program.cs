using System;
using System.Collections.Generic;
using MenuDemoClassLibrary;

namespace MenuDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //dollarihommat

            //var rdh = new RestaurantDataHandler();
            var rmf = new RestaurantMenuFunctions();

            var test = RestaurantDataHandler.GetAllDishesFromDB();

            var datatesting = new RestaurantDataHandler();
            //datatesting.GetXInY(1, "FoodItems", "Categories");

            //var datatesting2 = new RestaurantDataHandler();
            //datatesting2.GetFoodItemsInCategory(1);

            datatesting.TEST2();
            Console.WriteLine("---");

            ////datatesting.TestPrintEveryRestaurantFromDB();
            ////datatesting.TestPrintEverythingFromDB();


            ////rmf.StartMainMenu();


            ////var rdh = new RestaurantDataHandler();

            ////rdh.AddNewRestaurant();
            ////rdh.AddNewRestaurant();
            ////rdh.AddNewRestaurant();

            ////Console.WriteLine("asdasdasd");

            ////rdh.EditRestaurant();
            
            ////Console.WriteLine("hjghghj");

            ////rdh.EditRestaurant();

            ////Console.WriteLine("qqqqqqqqqqqq");

            //var rest1 = new Restaurant();
            //var rest1Menu1 = new Menu();
            //var rest1Menu2 = new Menu();
            //var rest1Category1 = new Category();
            //var rest1Category2 = new Category();
            //var rest1Category3 = new Category();
            //var rest1Category4 = new Category();
            //var rest1Subcategory1 = new Subcategory();
            //var rest1Subcategory2 = new Subcategory();
            //var rest1Food1 = new FoodItem();
            //var rest1Food2 = new FoodItem();
            //var rest1Food3 = new FoodItem();
            //var rest1Food4 = new FoodItem();
            //var rest1Food5 = new FoodItem();
            //var rest1Drink1 = new Drink();
            ////var allergenLactose = new Allergen();


            //rest1.RestaurantID = 2;
            //rest1.RestaurantName = "Test Restaurant";
            //rest1.RestaurantPhone = "401119922";
            //rest1.RestaurantAddress = "Test Road 123 A";
            //rest1.RestaurantOperational = true;



            //rest1Menu1.MenuID = -2;
            //rest1Menu1.MenuOrder = 1;
            //rest1Menu1.MenuName = "Test Menu";

            //rest1Menu2.MenuID = -3;
            //rest1Menu2.MenuOrder = 2;
            //rest1Menu2.MenuName = "Test Alternate Menu";



            //rest1Category1.CategoryID = -2;
            //rest1Category1.CategoryOrder = 1;
            //rest1Category1.CategoryName = "Appetizers";

            //rest1Category2.CategoryID = -3;
            //rest1Category2.CategoryOrder = 2;
            //rest1Category2.CategoryName = "Main Course";

            //rest1Category3.CategoryID = -4;
            //rest1Category3.CategoryOrder = 3;
            //rest1Category3.CategoryName = "Desserts";

            //rest1Category4.CategoryID = -5;
            //rest1Category4.CategoryOrder = 4;
            //rest1Category4.CategoryName = "Drinks";



            //rest1Subcategory1.SubcategoryID = -2;
            //rest1Subcategory1.SubcategoryOrder = 1;
            //rest1Subcategory1.SubcategoryName = "Borgars";

            //rest1Subcategory2.SubcategoryID = -3;
            //rest1Subcategory2.SubcategoryOrder = 2;
            //rest1Subcategory2.SubcategoryName = "Seafood";



            ////var r = Allergen.allergenChars[""];

            //rest1Food1.FoodID = -2;
            //rest1Food1.FoodOrder = 1; //öö tää ei varmaa toimi kätevästi näin
            //rest1Food1.FoodName = "Makkaraperunat";
            //rest1Food1.FoodPrice = 5.5f;
            ////rest1Food1.FoodAlcoholContent = 0;
            //rest1Food1.FoodDescription = "HK:n sinistä ja suomalaisia pottuja";
            ////allergeenit pitää miettiä

            //rest1Food2.FoodID = -3;
            //rest1Food2.FoodOrder = 2;
            //rest1Food2.FoodName = "Nakkikeitto";
            //rest1Food2.FoodPrice = 6.5f;
            ////rest1Food2.FoodAlcoholContent = 0;
            //rest1Food2.FoodDescription = "HK:n sinistä ja suomalaisia pottuja";

            //rest1Food3.FoodID = -4;
            //rest1Food3.FoodOrder = 4;
            //rest1Food3.FoodName = "Kalasalaatti";
            //rest1Food3.FoodPrice = 8.5f;
            ////rest1Food3.FoodAlcoholContent = 0;
            //rest1Food3.FoodDescription = "Lohta ja ruukkusalaattia";

            //rest1Food4.FoodID = -5;
            //rest1Food4.FoodOrder = 5;
            //rest1Food4.FoodName = "Kebab borgar";
            //rest1Food4.FoodPrice = 9.5f;
            ////rest1Food4.FoodAlcoholContent = 0;
            //rest1Food4.FoodDescription = "Burg";

            //rest1Food5.FoodID = -6;
            //rest1Food5.FoodOrder = 6;
            //rest1Food5.FoodName = "Uunimakkara borgar";
            //rest1Food5.FoodPrice = 16.5f;
            ////rest1Food5.FoodAlcoholContent = 0;
            //rest1Food5.FoodDescription = "HK:n sinistä ja suomalaisia pottuja";

            //rest1Drink1.FoodID = -7;
            //rest1Drink1.FoodOrder = 1;
            //rest1Drink1.FoodName = "Blörö";
            //rest1Drink1.FoodPrice = 4;
            ////rest1Drink1.FoodAlcoholContent = 90;
            //rest1Drink1.FoodDescription = "Kahvia ja pirtua, jälkkäriksi rööki";
            //rest1Drink1.DrinkSize = 0.5f;




            ////listat
            //rest1Category1.FoodItemsList.Add(rest1Food3);

            //rest1Category2.FoodItemsList.Add(rest1Food1);
            //rest1Category2.FoodItemsList.Add(rest1Food2);

            //rest1Subcategory1.FoodItemsList.Add(rest1Food4);
            //rest1Subcategory1.FoodItemsList.Add(rest1Food5);



            //rest1Category2.SubcategoriesList.Add(rest1Subcategory1);
            //rest1Category2.SubcategoriesList.Add(rest1Subcategory2);

            //rest1Menu1.CategoriesList.Add(rest1Category1);
            //rest1Menu1.CategoriesList.Add(rest1Category2);
            //rest1Menu1.CategoriesList.Add(rest1Category3);
            //rest1Menu1.CategoriesList.Add(rest1Category4);

            //rest1.MenusList.Add(rest1Menu1);
            //rest1.MenusList.Add(rest1Menu2);



            //foreach (var menu in rest1.MenusList)
            //{
            //    Console.WriteLine(menu.MenuName);
            //}
        }
    }
}
