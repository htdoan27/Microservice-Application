using Mango.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        //private readonly IOrderService _orderService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
            //_orderService = orderService;
        }
        public async Task<IActionResult> LoadCartDtoBasedOnLoggedInUser()
        {
            return View(await LoadCartDtoBasedOnLoggedInUser());
        }


    }
}
