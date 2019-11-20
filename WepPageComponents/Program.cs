using System;

namespace WepPageComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            //object of button class
            Button btn = new Button();

            Button_Event_Listener listener = new Button_Event_Listener();
            listener.Listen(btn);

            btn.Begin();


            
            //object of textbox class
            Textbox txt = new Textbox();

            Textbox_Event_Listener listener2 = new Textbox_Event_Listener();
            listener2.Listen(txt);

            txt.Begin2();



            //object of combobox class
            ComboBox combo = new ComboBox();

            Combobox_Event_Listener listener3 = new Combobox_Event_Listener();
            listener3.Listen(combo);

            combo.Begin2();


            //object of AddressBar class
            AddressBar adrbar = new AddressBar();

            AddressBar_Event_Listener listener4 = new AddressBar_Event_Listener();
            listener4.Listen(adrbar);

            adrbar.Begin2();


            //object of GridView class
            GridView gridview = new GridView();

            GridView_Event_Listener listener5 = new GridView_Event_Listener();
            listener5.Listen(gridview);

            gridview.Begin2();


            //object of NavigationBar class
            NavigationBar nav = new NavigationBar();

            NavigationBar_Event_Listener listener6 = new NavigationBar_Event_Listener();
            listener6.Listen(nav);

            nav.Begin2();


            //object of Checkbox class
            CheckBox chbox = new CheckBox();

            CheckBox_Event_Listener listener7 = new CheckBox_Event_Listener();
            listener7.Listen(chbox);

            chbox.Begin2();


            //object of Radiobutton class
            RadioButtons radiobtn = new RadioButtons();

            RadioButtons_Event_Listener listener8 = new RadioButtons_Event_Listener();
            listener8.Listen(radiobtn);

            radiobtn.Begin2();
        }
    }
}
