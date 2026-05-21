using System.Collections.Generic;

namespace Pizza_ordering_system
{
    public class Cart
    {
        public static List<Pizza> Items { get; set; } = new List<Pizza>();

        public static void Clear()
        {
            Items.Clear();
        }
    }
}