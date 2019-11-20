using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    public class GridView
    {
        //Events
        public EventHandler GridViewClick;

        //Constructor
        public GridView()
        {
            Console.WriteLine("\nConstructor of GridView called...");
        }

        //Begin method of GridView
        public void Begin2()
        {
            //If there are no subscribers to GridViewclick event
            if (GridViewClick != null)
            {
                //Event called
                GridViewClick(this, null);
            }
        }
    }
}
