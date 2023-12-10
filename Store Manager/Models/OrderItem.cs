namespace Store_Manager.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

      //relationship
        public OrderTable Order { get; set; }
        public Product Product { get; set; }

    }
}
