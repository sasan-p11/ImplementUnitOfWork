using Domain.Interfaces;
using Domain.Models;

namespace Repository;
class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(DataContext context) : base(context)
    {

    }
}
