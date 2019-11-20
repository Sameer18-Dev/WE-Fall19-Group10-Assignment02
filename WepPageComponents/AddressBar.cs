using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    public class AddressBar
    {
        //Event
        public EventHandler AddressBarClick;

        //Constructor
        public AddressBar()
        {
            Console.WriteLine("\nConstructor of Address bar called...");
        }

        //Begin method of Addressbar
        public void Begin2()
        {
            //If there are no subscribers to Addressbarclick event
            if (AddressBarClick != null)
            {
                //Event called
                AddressBarClick(this, null);
            }
        }
    }
}
