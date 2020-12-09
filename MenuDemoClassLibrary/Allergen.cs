using System;
using System.Collections.Generic;
using System.Text;

namespace MenuDemoClassLibrary
{
    public class Allergen
    {
        private bool _foodAllergen;
        public bool FoodAllergen
        {
            get { return _foodAllergen; } 
            set { _foodAllergen = value; }
        }

        public enum AllergenType { Laktoosi, Pähkinä, Gluteeni};
        public Dictionary<AllergenType, string> allergenChars = new Dictionary<AllergenType, string>()
        { {AllergenType.Laktoosi, "L" }, { AllergenType.Gluteeni, "G"}, { AllergenType.Pähkinä, "P"} };


        public Allergen()
        {

        }
    }
}
