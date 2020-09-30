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

        // all families that visited this day
        private HashSet<Family> families = new HashSet<Family>();



        public Day(Evenement ogEvenement, int dayID)
        {
            this.ogEvenement = ogEvenement;
            this.dayID = dayID;
        }


        public void addFamily(Family family)
        {
            families.Add(family);
        }



    }
}
