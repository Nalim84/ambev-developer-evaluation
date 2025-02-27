namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale(Guid saleId, string saleNumber, DateTime saleDate, decimal totalAmount
, bool isCancelled, List<SaleItem> items, Guid customerId, string customerName
, Guid branchId, string branchName)
{
    public Guid SaleId { get; set; } = saleId;
    public string SaleNumber { get;  set; } = saleNumber;
    public DateTime SaleDate { get;  set; } = saleDate;
    public decimal TotalAmount { get;  set; } = totalAmount;
    public bool IsCancelled { get;  set; } = isCancelled;
    public List<SaleItem> Items { get;  set; } = items;

    public Guid CustomerId { get;  set; } = customerId;// External Identity
    public string CustomerName { get;  set; } = customerName;// Denormalized data
    public Guid BranchId { get;  set; } = branchId;// External Identity
    public string BranchName { get;  set; } = branchName;// Denormalized data

    public void CalculateTotal()
    {
        TotalAmount = Items.Sum(item => item.TotalPrice);
    }
}
