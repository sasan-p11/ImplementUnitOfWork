using System.ComponentModel.DataAnnotations;

namespace Domain.Models;
public class Order
{
    [Key]
    public int OrderId { get; set; }
    public string OrderDetails { get; set; }
    public bool IsActive { get; set; }
    public DateTime OrderedDate { get; set; }
}