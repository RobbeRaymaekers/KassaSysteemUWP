using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace KassaSysteemUWP.Classes
{
    class Evenement
    {

        // Name of the event
        private string _name;

        // start date of the event
        private DateTime dateEvent;

        // the amount of days the event lasts for
        private int _amntDays;

        //list of all the days this event lasts for
        private List<Day> days = new List<Day>();

        public static ObservableCollection<Evenement> EventList = new ObservableCollection<Evenement>();
        public static HashSet<String> EventNameList = new HashSet<string>();


        public int AmntDays { get => _amntDays; set => _amntDays = value; }
        public string Name
        {
            get => _name;
            set
            {
                if (EventNameList.Contains(value) || value == "")
                {
                    throw new ArgumentException();
                }
                else
                { 
                    _name = value;
                    EventNameList.Add(value);
                }
            }
        }

        public Evenement(string name, int amntDays)
        {
            //initialise all class vars
            Name = name;
            AmntDays = amntDays;

            //create all the days for the event
            for(int i = 0; i < amntDays; i++)
            {
                days.Add(new Day(this, i));
            }

            //we add this event to the list of all events
            EventList.Add(this);
            

        }

        public void changeDays(int newAmntDays)
        {
            if(newAmntDays == AmntDays) { return; }
            else if (newAmntDays > AmntDays)
            {
                for (int i = 0; i < newAmntDays - AmntDays; i++)
                {
                    days.Add(new Day(this, AmntDays + 1 + i));
                }
            }
            else
            {
                //TODO REMOVE DAYS!!
            }
            AmntDays = newAmntDays;
        }

        
    }
}
