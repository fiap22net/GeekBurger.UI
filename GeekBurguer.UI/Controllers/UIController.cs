using GeekBurguer.UI.Contract;
using Microsoft.AspNetCore.Mvc;

namespace GeekBurguer.UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UIController : Controller
    {
        [HttpPost("face")]
        public IActionResult Face([FromBody] Face faceId)
        {
            try
            {
                var result = new UserToGet()
                {
                    UserId = 11111,
                    Processing = true
                };
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("foodRestriction")]
        public IActionResult FoodRestriction([FromBody] FoodRestrictions foodRestrictions)
        {
            try
            {
                var result = new UserToGet()
                {
                    UserId = 11111,
                    Processing = true
                };
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("order")]
        public IActionResult Order([FromBody] OrderToGet orders)
        {
            try
            {
                var result = new Order()
                {
                    orderId = 11111,
                    storeName = "Paulista",
                    total = 10.20M
                };

                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("newOrder")]
        public IActionResult NewOrder([FromBody] NewOrder newOrder)
        {
            return Ok("Add new order");
        }
    }
}
