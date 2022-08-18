using System;
namespace MenuStudio
{
    public class Menu
    {
        Dictionary<double,string> ItemsPriceList { get; set; }
        List<object> FullMenu { get; set; }
        List<string> CategoryOrder { get; set; }
        DateTime MenuLastUpdated { get; set; }
        int NumberOfNewItems { get; set; }

        public Menu(List<object> fullMenu)
        {
            FullMenu = fullMenu;
        }
    }
}

