using KassaSysteemUWP.Classes;
using System;
using System.Collections.Generic;
using System.Xml;

namespace KassaSysteemUWP
{
    public static class MenuReader
    {

        private static string PATH_TO_MENU = @"Menu\";
        private static string pathToIcoFile = System.AppDomain.CurrentDomain.BaseDirectory + "//Menu//";

        public static List<Product> GetMenuByType(string menuName, ProductType type)
        {
            List<Product> products = new List<Product>();

            XmlDocument doc = new XmlDocument();
            doc.Load(pathToIcoFile + type + ".xml");

            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string name = node.ChildNodes[0].InnerText;
                float price = float.Parse(node.ChildNodes[1].InnerText);

                products.Add(new Product(name, price, type));
            }

            // TODO 
            return products;
        }

        public static Menu LoadWholeMenu(string menuName)
        {
            Menu menu = new Menu();

            menu.Drinks = GetMenuByType(menuName, ProductType.Drinks);
            menu.Desserts = GetMenuByType(menuName, ProductType.Dessert);
            menu.MainDishes = GetMenuByType(menuName, ProductType.Main);

            return menu;
        }


    }
}
