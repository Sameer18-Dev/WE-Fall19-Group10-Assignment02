using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    class AddressBar_Event_Listener
    {
        public void Listen(AddressBar Adrbar)
        {
            Adrbar.AddressBarClick += OnBtnClickCallThis;
        }

        public void OnBtnClickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("Address Bar just clicked with ID = " + Id + " , Name = " + Name + " , Color = " + Color);

        }

        //Properties

        public int Id = 4;
        public String Name = "Google address bar";
        public String Color = "Yellow";
    }
}
