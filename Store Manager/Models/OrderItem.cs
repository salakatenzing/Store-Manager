using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Store_Manager.Models
{
    
    public class OrderItem
    {
        [Key]
        public int id { get; set; }
        public int orderid { get; set; }
        public int productid { get; set; }
        public int quantity { get; set; }

        //relationship
       
        public virtual OrderTable Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
