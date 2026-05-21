using System;

namespace Pizza_ordering_system
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentMethod { get; set; }

        public Customer() { }

        public Customer(string firstName, string lastName, string address, string phone, string email, string paymentMethod)
        {
            FirstName = firstName ?? "";
            LastName = lastName ?? "";
            Address = address ?? "";
            Phone = phone ?? "";
            Email = email ?? "";
            PaymentMethod = paymentMethod ?? "";
        }
    }
}