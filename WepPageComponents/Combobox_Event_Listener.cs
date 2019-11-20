using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    class Combobox_Event_Listener
    {
        public void Listen(ComboBox combox)
        {
            combox.Comboboxclick += OnBtnClickCallThis;
        }

        public void OnBtnClickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("Combo box just clicked with ID = " + Id + " , Name = " + Name + " , Color = " + Color);

        }

        //Properties

        public int Id = 3;
        public String Name = "Drop down list";
        public String Color = "Green";
    }
}
