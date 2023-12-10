namespace Store_Manager.Models
{
    public class OrderItem
    {
        public int id { get; set; }
        public int orderod { get; set; }
        public int productid { get; set; }
        public int quantity { get; set; }

      //relationship
        public OrderTable Order { get; set; }
        public Product Product { get; set; }

    }
}
