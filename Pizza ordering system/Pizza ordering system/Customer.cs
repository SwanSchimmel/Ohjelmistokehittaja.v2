namespace Pizza_ordering_system
{
    public class Customer   // ← тоже лучше сделать public
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentMethod { get; set; }
    }
}