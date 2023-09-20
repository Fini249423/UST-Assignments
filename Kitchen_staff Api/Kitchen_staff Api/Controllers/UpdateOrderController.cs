using Microsoft.AspNetCore.Mvc;
//using UpdateOrdersMicroservice.Data;
using UpdateOrdersMicroservice.Models;
using System;
using System.Linq;
using Kitchen_staff_Api.DBContexts;

namespace UpdateOrdersMicroservice.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class UpdateOrderController : ControllerBase
    {
         readonly ProductContext  _context;

        public UpdateOrderController(ProductContext  context)
        {
            _context = context;
        }

        // PUT: api/orders/{orderId}
        [HttpPut("{orderId}")]
        public IActionResult UpdateOrder(int orderId, [FromBody] UpdateOrderModel updateModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var order = _context.Order.FirstOrDefault(o => o.OrderID == orderId);
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
            _context.SaveChanges();

            return Ok(order);
        }
    }
}
