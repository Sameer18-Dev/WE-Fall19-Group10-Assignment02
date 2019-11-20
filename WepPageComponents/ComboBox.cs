using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    public class ComboBox
    {
        public EventHandler Comboboxclick;
        //constructor
        public ComboBox()
        {
            Console.WriteLine("\nConstructor of combo box called..");
        }

        //Begin method of combobox
        public void Begin2()
        {
            //If there are no subscribers to Comboboxclick event
            if (Comboboxclick != null)
            {
                //Event called
                Comboboxclick(this, null);
            }
        }
    }
}
