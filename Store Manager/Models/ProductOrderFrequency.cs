namespace Store_Manager.Models
{
    public class ProductOrderFrequency
    {
        public int productid { get; set; }
        public int orderfrequency { get; set; }

       //relationship
        public Product Product { get; set; }
    }
}
