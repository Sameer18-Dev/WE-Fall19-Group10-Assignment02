using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    class NavigationBar_Event_Listener
    {
        public void Listen(NavigationBar navbar)
        {
            navbar.NavigationBarClick += OnBtnClickCallThis;
        }

        public void OnBtnClickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("Navigation Bar just clicked with ID = " + Id + " , Name = " + Name + " , Color = " + Color);

        }

        //Properties

        public int Id = 6;
        public String Name = "Navigating to Home page";
        public String Color = "peach";
    }
}
