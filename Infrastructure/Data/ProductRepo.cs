using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entites;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
    public class ProductRepo:IproductRepos
    {
         public StoreContext _Context { get; }
        public ProductReporasatriy(StoreContext context)
        {
            _Context = context;
            
        }
        public async Task<Product> GetProductByIdasync(int id)
        {
            return await _Context.products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsasync()
        {
            return await _Context.products.ToListAsync();
        }
    }
}