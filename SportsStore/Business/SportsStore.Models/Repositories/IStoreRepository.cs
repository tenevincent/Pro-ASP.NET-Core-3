using System;
using System.Linq;

namespace SportsStore.Business.Repositories
{
    public interface IStoreRepository
    { 
        IQueryable<Product> Products { get; }


    }
}
