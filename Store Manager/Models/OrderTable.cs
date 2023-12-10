namespace Store_Manager.Models
{
    public class OrderTable
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }

        //relationship
        public Customer Customer { get; set; }
    }
}
