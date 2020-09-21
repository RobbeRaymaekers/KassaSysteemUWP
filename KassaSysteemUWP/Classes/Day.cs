using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaSysteemUWP.Classes
{
    class Day
    {

        // Event belonging to this day
        private Evenement ogEvenement;

        // shows which day of the event this is
        private int dayID;



        public Day(Evenement ogEvenement, int dayID)
        {
            this.ogEvenement = ogEvenement;
            this.dayID = dayID;
        }

    }
}
