using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    class Button_Event_Listener
    {
            
        public void Listen(Button btn)
        {
            btn.BtnClick += OnBtnClickCallThis;
        }

        public void OnBtnClickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("Button just clicked with ID = " +Id + " , Name = " +Name + " , Color = " +Color);
        }

        //Properties

        public int Id = 1;
        public String Name="Save Button";
        public String Color = "Red";



    }
}
