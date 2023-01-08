﻿using DrinksShop.Api.Entities;
using DrinksShop.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using DrinksShop.Api.Data;
using DrinksShop.Api.Repositories.Contracts;

namespace DrinksShop.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly DrinksShopDbContext drinksShopDbContext;

        public ShoppingCartRepository(DrinksShopDbContext drinksShopDbContext)
        {
            this.drinksShopDbContext = drinksShopDbContext;
        }

        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await this.drinksShopDbContext.CartItems.AnyAsync(c => c.CartId == cartId &&
                                                                     c.ProductId == productId);

        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {
                var item = await (from product in this.drinksShopDbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Qty = cartItemToAddDto.Qty
                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await this.drinksShopDbContext.CartItems.AddAsync(item);
                    await this.drinksShopDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;

        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await this.drinksShopDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                this.drinksShopDbContext.CartItems.Remove(item);
                await this.drinksShopDbContext.SaveChangesAsync();
            }

            return item;

        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.drinksShopDbContext.Carts
                          join cartItem in this.drinksShopDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.drinksShopDbContext.Carts
                          join cartItem in this.drinksShopDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public async Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            var item = await this.drinksShopDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                item.Qty = cartItemQtyUpdateDto.Qty;
                await this.drinksShopDbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }
    }
}
