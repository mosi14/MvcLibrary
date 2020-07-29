using E_ShopBook.DataAccess.Data;
using E_ShopBook.DataAccess.Repository.IRepository;
using E_ShopBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_ShopBook.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            _db.Update(company);
        }
    }
}
