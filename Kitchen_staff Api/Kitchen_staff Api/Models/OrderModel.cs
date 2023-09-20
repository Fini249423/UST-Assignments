

using System.ComponentModel.DataAnnotations;

namespace OrderManagementMicroservice.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public DateTime OrderTime { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        public string Notes { get; set; }

        // Add more properties as needed

        public int KitchenStaffID { get; set; } // Foreign key to the assigned kitchen staff
    }
}
