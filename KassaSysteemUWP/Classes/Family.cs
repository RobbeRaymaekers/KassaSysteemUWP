using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaSysteemUWP.Classes
{
    class Family
    {
        // name of the family
        private string name;

        // Id of the day that this family visited the event
        private int dayID;



        public Family(string name, int dayID)
        {
            this.name = name;
            this.dayID = dayID;
        }

    }
}
