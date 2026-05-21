using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizza_ordering_system
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
        public int Quantity { get; set; }
        public double Price { get; set; }

        // Для красивого отображения в DataGridView
        public string ToppingsDisplay => Toppings != null && Toppings.Count > 0
            ? string.Join(", ", Toppings)
            : "Без добавок";
    }
}