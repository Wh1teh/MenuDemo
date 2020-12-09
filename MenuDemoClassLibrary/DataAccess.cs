using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace MenuDemoClassLibrary
{
    public class DataAccess
    {
        public static string currentDBName = "MenuDemoDB";

        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
