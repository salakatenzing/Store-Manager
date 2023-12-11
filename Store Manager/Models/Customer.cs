namespace Store_Manager.Models
{
    public class Customer
    {
        public int id { get; set; }
        //string is immutable but can be null
        public string name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
    }
}
