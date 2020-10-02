using System.Collections.Generic;
using System.Xml.Serialization;

namespace KassaSysteemUWP.Classes
{
    public class Family
    {
        // name of the family
        private string name;

        // Id of the day that this family visited the event
        [XmlIgnore]
        private int dayID;

        //the amount of money spent 
        private float moneySpent = 0;

        //The money already paid by the family
        private float moneyPaid = 0;

        //table number of this family
        private int tableNr;

        //all the items eaten by the family
        private List<Product> foodEaten = new List<Product>();

        public string Name { get => name; set => name = value; }


        public Family(string name, int dayID, int tableNr)
        {
            this.name = name;
            this.dayID = dayID;
            this.tableNr = tableNr;
        }


        public void addProduct(Product product)
        {
            foodEaten.Add(product);
        }

    }
}
