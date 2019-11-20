using System;
using System.Collections.Generic;
using System.Text;

namespace WepPageComponents
{
    class GridView_Event_Listener
    {
        public void Listen(GridView grid)
        {
            grid.GridViewClick += OnBtnClickCallThis;
        }

        public void OnBtnClickCallThis(object sender, EventArgs e)
        {
            Console.WriteLine("GridView just clicked with ID = " + Id + " , Name = " + Name + " , Color = " + Color);

        }

        //Properties

        public int Id = 5;
        public String Name = "Date input grid view";
        public String Color = "Orange";
    }
}
