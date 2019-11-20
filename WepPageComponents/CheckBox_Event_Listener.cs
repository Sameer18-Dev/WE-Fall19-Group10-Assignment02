using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    class CheckBox_Event_Listener
    {
        public void Listen(CheckBox chbox)
        {
            chbox.CheckBoxClick += OnBtnClickCallThis;
        }

        public void OnBtnClickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("Checkbox just clicked with ID = " + Id + " , Name = " + Name + " , Color = " + Color);

        }

        //Properties

        public int Id = 7;
        public String Name = "Form checkbox";
        public String Color = "purple";
    }
}
