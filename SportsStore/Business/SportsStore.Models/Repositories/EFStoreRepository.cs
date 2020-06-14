using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace SportsStore.Business.Repositories
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
