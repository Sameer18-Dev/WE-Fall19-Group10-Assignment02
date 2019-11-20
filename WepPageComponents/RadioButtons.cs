using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    public class RadioButtons
    {
        //Events
        public EventHandler RadioButtonsClick;

        //Constructor
        public RadioButtons()
        {
            Console.WriteLine("\nConstructor of Radio buttons called...");
        }



        //Begin method of Radiobuttons
        public void Begin2()
        {
            //If there are no subscribers to RadioButtonsClick event
            if (RadioButtonsClick != null)
            {
                //Event called
                RadioButtonsClick(this, null);
            }
        }
    }
}
