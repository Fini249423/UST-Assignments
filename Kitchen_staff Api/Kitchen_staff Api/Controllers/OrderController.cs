//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using UpdateOrdersMicroservice.Models;

//namespace Kitchen_staff_Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class OrderController : ControllerBase
//    {
//    }
//}
//using Microsoft.AspNetCore.Mvc;
//using OrderManagementMicroservice.Data;
//using OrderManagementMicroservice.Models;
//using System;
//using System.Linq;

using Kitchen_staff_Api.DBContexts;
using Microsoft.AspNetCore.Mvc;
using UpdateOrdersMicroservice.Models;

namespace OrderManagementMicroservice.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly ProductContext pc;

        public OrderController(ProductContext pc)
        {
            this.pc = pc;
        }

        // GET: api/orders/{orderId}
        [HttpGet("{orderId}")]
        public IActionResult GetOrder(int orderId)
        {
            var order = pc.Order.FirstOrDefault(o => o.OrderID == orderId);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // PUT: api/orders/{orderId}
        [HttpPut("{orderId}")]
        public IActionResult UpdateOrder(int orderId, [FromBody] UpdateOrderModel updateModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var order = pc.Order.FirstOrDefault(o => o.OrderID == orderId);
            if (order == null)
            {
                return NotFound();
            }

            // Update order status and other properties here
            if (!string.IsNullOrEmpty(updateModel.NewOrderStatus))
            {
                order.OrderStatus = updateModel.NewOrderStatus;
            }

            if (!string.IsNullOrEmpty(updateModel.UpdatedDetails))
            {
                order.Notes = updateModel.UpdatedDetails;
            }

            // Save changes to the database
            pc.SaveChanges();

            return Ok(order);
        }
    }
}
