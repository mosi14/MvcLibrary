using E_ShopBook.DataAccess.Data;
using E_ShopBook.DataAccess.Repository.IRepository;
using E_ShopBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_ShopBook.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.Update(obj);
        }
    }
}
