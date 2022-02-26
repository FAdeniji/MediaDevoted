using mediadevoted.application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using mediadevoted.domain.Entities;

namespace mediadevoted.api.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _repository;

        [HttpPost]
        public Task<Cart> AddToCart(Cart cart)
        {
            return _repository.AddToCartAsync(cart);
        }

        [HttpGet]
        public Task<Cart> FetchCart()
        {
            return _repository.FetchCartAsync();
        }
    }
}
