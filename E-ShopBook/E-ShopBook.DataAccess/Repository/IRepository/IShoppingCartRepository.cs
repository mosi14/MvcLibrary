using E_ShopBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_ShopBook.DataAccess.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
