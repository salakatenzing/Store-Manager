namespace Store_Manager.Models
{
    public class ProductOrderFrequency
    {
        public int ProductId { get; set; }
        public int OrderFrequency { get; set; }

       //relationship
        public Product Product { get; set; }
    }
}
