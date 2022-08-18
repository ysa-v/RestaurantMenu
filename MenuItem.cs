using System;
using System.Collections.Generic
namespace MenuStudio
{
    public class MenuItems
    {
        double Price { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Category { get; set; }
        bool MarkedAsNew { get; set; }
        double Popularity { get; set; }
        DateTime ItemCreated { get; set; }
        DateTime ItemUpdated { get; set; }

        public MenuItems(double price, string title, string description, bool markedAsNew)
        {
            Price = price;
            Title = title;
            Description = description;
            MarkedAsNew = markedAsNew;
        }

        public MenuItems()
    }
}

