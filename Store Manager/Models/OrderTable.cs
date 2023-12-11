using System.ComponentModel.DataAnnotations;

namespace Store_Manager.Models
{
    public class OrderTable
    {
        [Key]
        public int id { get; set; }
        public int customerid { get; set; }
        public DateTime date { get; set; }
        public decimal totalamount { get; set; }

        //relationship
        public virtual Customer Customer { get; set; }

        //to handle list of order items in one order
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
