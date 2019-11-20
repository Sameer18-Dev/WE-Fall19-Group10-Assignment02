using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    class Textbox_Event_Listener
    {
      
        public void Listen(Textbox txtbox)
        {
            txtbox.Txtboxclick += OnBtnClickCallThis;
        }

        public void OnBtnClickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("Textbox just clicked with ID = " + Id + " , Name = " + Name + " , Color = " + Color);
            
        }

        //Properties

        public int Id = 2;
        public String Name = "Email Textbox";
        public String Color = "Black";
    }
}
