using Domain.Interfaces;

namespace Repository;
public class UnitOfWork : IUnitOfWork
{
 private readonly DataContext _context;
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get; }

        public UnitOfWork(DataContext DbContext,
            IOrderRepository OrderRepository,
            IProductRepository ProductRepository)
        {
            this._context = DbContext;
            this.Orders = OrderRepository;
            this.Products = ProductRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
}