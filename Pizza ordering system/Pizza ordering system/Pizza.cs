using System;
using System.Collections.Generic;

namespace Pizza_ordering_system
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
        public int Quantity { get; set; }
        public double Price { get; set; }

        public string ToppingsDisplay => Toppings.Count > 0
            ? string.Join(", ", Toppings)
            : "Без добавок";
    }
}