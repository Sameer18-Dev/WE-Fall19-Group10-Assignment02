using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    public class NavigationBar
    {
        //Events
        public EventHandler NavigationBarClick;

        //Constructor
        public NavigationBar()
        {
            Console.WriteLine("\nConstructor of Navigation Bar called...");
        }


        //Begin method of NavigationBar
        public void Begin2()
        {
            //If there are no subscribers to NavigationBarClick event
            if (NavigationBarClick != null)
            {
                //Event called
                NavigationBarClick(this, null);
            }
        }
    }
}
