using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    public class Button
    {
        //Events
        
        public EventHandler BtnClick;

        
        //Constructor
        public Button()
        {
            Console.WriteLine("Constructor of button called");
        }

        //Begin method of button
        public void Begin()
        {
            //If there are no subscribers to BtnClick event
            if(BtnClick!=null)
            {      
                //Event called
                BtnClick(this, null);
            }
        }
    }
}
