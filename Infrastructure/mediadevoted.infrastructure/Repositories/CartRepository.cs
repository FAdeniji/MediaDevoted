using mediadevoted.application.Interfaces;
using mediadevoted.data.ef;
using mediadevoted.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mediadevoted.infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {

        private readonly MdContext _mdContext;

        public CartRepository(MdContext mdContext)
        {
            _mdContext = mdContext;
        }

        /// <summary>
        /// save to cart
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public async Task<Cart> AddToCartAsync(Cart cart)
        {
            await _mdContext.Carts.AddAsync(cart);
            await _mdContext.SaveChangesAsync();
            return cart;
        }

        /// <summary>
        /// fetch cart
        /// </summary>
        /// <returns></returns>
        public async Task<Cart> FetchCartAsync()
        {
            return await _mdContext.Carts.FirstAsync();
        }
    }
}
