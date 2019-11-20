using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    public class Textbox
    {
        //Event
        public EventHandler Txtboxclick;
         
        public Textbox()
        {
            Console.WriteLine("\nConstructor of Textbox called");
        }


        //Begin method of Textbox
        public void Begin2()
        {
            //If there are no subscribers to Txtboxclick event
            if (Txtboxclick != null)
            {
                //Event called
                Txtboxclick(this, null);
            }
        }
    }
}
