using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;
public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(DataContext context) : base(context)
    {

    }
    public async Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName)
    {
        return await _context.Orders.Where(c => c.OrderDetails.Contains(orderName)).ToListAsync();
    }
}