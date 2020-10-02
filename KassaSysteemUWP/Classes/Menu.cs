using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaSysteemUWP.Classes
{
    public class Menu
    {

        private string name;

        private List<Product> drinks;
        private List<Product> mainDishes;
        private List<Product> desserts;

        public List<Product> Desserts { get => desserts; set => desserts = value; }
        public string Name { get => name; set => name = value; }
        internal List<Product> MainDishes { get => mainDishes; set => mainDishes = value; }
        internal List<Product> Drinks { get => drinks; set => drinks = value; }
    }
}
