//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using SearchOrdersMicroservice.Models;

//namespace Kitchen_staff_Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class SearchOrderController : ControllerBase
//    {
//    }
//}
using Kitchen_staff_Api.DBContexts;
using Microsoft.AspNetCore.Mvc;

//using SearchOrdersMicroservice.Data;
using SearchOrdersMicroservice.Models;
using System;
using System.Linq;

namespace SearchOrdersMicroservice.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class SearchOrderController : ControllerBase
    {
         readonly ProductContext  _context;

        public SearchOrderController(ProductContext  context)
        {
            _context = context;
        }

        // GET: api/orders
        [HttpGet]
        public IActionResult SearchOrders([FromQuery] SearchOrderCriteria searchCriteria)
        {
            var query = _context.Order.AsQueryable();

            // Apply search criteria to filter orders
            if (searchCriteria.OrderID.HasValue)
            {
                query = query.Where(o => o.OrderID == searchCriteria.OrderID.Value);
            }

            if (!string.IsNullOrEmpty(searchCriteria.CustomerName))
            {
                query = query.Where(o => o.CustomerName.Contains(searchCriteria.CustomerName));
            }

            // Apply more search criteria as needed

            var orders = query.ToList();
            return Ok(orders);
        }
    }
}
