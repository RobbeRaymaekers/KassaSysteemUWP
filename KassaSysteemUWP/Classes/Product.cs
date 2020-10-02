﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KassaSysteemUWP.Classes
{
    class Product
    {
        public string name;

        public float price;

        [XmlIgnore]
        private ProductType productType;

        public Product(string name, float price, ProductType pt)
        {
            this.name = name;
            this.price = price;
            this.productType = pt;
        }




    }

    enum ProductType
    { 
        Drink,
        Main,
        Dessert
    }
}