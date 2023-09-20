using Microsoft.EntityFrameworkCore;
using OrderManagementMicroservice.Models;

namespace Kitchen_staff_Api.DBContexts
{
    public class ProductContext :DbContext
    {
        
        public ProductContext(DbContextOptions<ProductContext> option):base(option)
        {
            
        }
      public  DbSet<OrderModel> Order { get; set; }
    }
}
