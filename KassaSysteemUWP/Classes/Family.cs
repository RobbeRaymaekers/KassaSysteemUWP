using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KassaSysteemUWP.Classes
{
    class Family
    {
        // name of the family
        private string name;

        // Id of the day that this family visited the event
        [XmlIgnore]
        private int dayID;

        //the amount of money spent 
        private float moneySpent = 0;



        public Family(string name, int dayID)
        {
            this.name = name;
            this.dayID = dayID;
        }

    }
}
