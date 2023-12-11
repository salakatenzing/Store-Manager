namespace Store_Manager.Models
{
    public class ProductOrderFrequency
    {
        public int id { get; set; }
        public int productid { get; set; }
        public int orderfrequency { get; set; }

       //relationship
        public virtual Product Product { get; set; }
    }
}
