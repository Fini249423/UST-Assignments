
using System.ComponentModel.DataAnnotations;

namespace UpdateOrdersMicroservice.Models
{
    public class UpdateOrderModel
    {
        [Required]
        public int OrderID { get; set; }

        public string NewOrderStatus { get; set; }

        public string UpdatedDetails { get; set; }

        // Add more properties as needed
    }
}
