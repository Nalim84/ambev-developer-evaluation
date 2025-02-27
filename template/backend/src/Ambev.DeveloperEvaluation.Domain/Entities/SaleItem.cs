
namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class SaleItem(
     Guid saleItemId ,Guid saleId ,Guid productId    ,string productName    
    ,int quantity ,decimal unitPrice  ,decimal discount      
    ,decimal totalPrice    
    ,bool isCancelled)      
{
    public Guid SaleItemId { get; set; } = saleItemId;
    public Guid SaleId { get; set; } = saleId;
    public Guid ProductId { get; set; } = productId; // External Identity
    public string ProductName { get; set; } = productName; // Denormalized data
    public int Quantity { get; set; } = quantity;
    public decimal UnitPrice { get; set; } = unitPrice;
    public decimal Discount { get; set; } = discount;
    public decimal TotalPrice { get; set; } = totalPrice;
    public bool IsCancelled { get; set; } = isCancelled;
}
