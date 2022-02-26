using mediadevoted.domain.Entities;
using System.Threading.Tasks;

namespace mediadevoted.application.Interfaces
{
    public interface ICartRepository
    {
        /// <summary>
        /// Add item to cart
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        Task<Cart> AddToCartAsync(Cart cart);

        /// <summary>
        /// Fetch user's cart
        /// </summary>
        /// <returns></returns>
        Task<Cart> FetchCartAsync();
    }
}
