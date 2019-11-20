using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    class RadioButtons_Event_Listener
    {
        public void Listen(RadioButtons radio)
        {
            radio.RadioButtonsClick += OnBtnClickCallThis;
        }

        public void OnBtnClickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("Radio buttons just clicked with ID = " + Id + " , Name = " + Name + " , Color = " + Color);
            Console.ReadLine();

        }

        //Properties

        public int Id = 8;
        public String Name = "Form radio buttons";
        public String Color = "pink";
    }
}
