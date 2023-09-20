namespace SearchOrdersMicroservice.Models
{
    public class SearchOrderCriteria
    {
        public int? OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime? OrderTimeFrom { get; set; }
        public DateTime? OrderTimeTo { get; set; }
        public string DeliveryAddress { get; set; }

        // Add more search criteria as needed
    }
}
