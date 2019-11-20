using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    public class CheckBox
    {
        //Events
        public EventHandler CheckBoxClick;

        //Constructor
        public CheckBox()
        {
            Console.WriteLine("\nConstructor of Checkbox called...");
        }



        //Begin method of Checkbox
        public void Begin2()
        {
            //If there are no subscribers to CheckBoxClick event
            if (CheckBoxClick != null)
            {
                //Event called
                CheckBoxClick(this, null);
            }
        }
    }
}
