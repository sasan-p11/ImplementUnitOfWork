using Domain.Models;

namespace Domain.Interfaces;
public interface IOrderRepository : IGenericRepository<Order>
{
    Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName);
}