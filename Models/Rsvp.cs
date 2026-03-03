namespace EventManagement.Models
{
    public class Rsvp
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string TransactionId {  get; set; }
        public string Email { get; set; }
        public int Guests { get; set; }
        public string PaymentMethod { get; set; }
        public int TicketPrice { get; set; }
        public int Total {  get; set; }

        public string UserId { get; set; }
        public DateTime? RegisteredAt { get; set; }

    }
}
