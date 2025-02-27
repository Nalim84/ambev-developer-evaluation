using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application;

public class Discounts
{
    public void ApplyDiscounts(Sale sale)
    {
        foreach (var item in sale.Items)
        {
            if (item.Quantity > 20)
            {
                throw new InvalidOperationException("Cannot sell more than 20 identical items.");
            }

            if (item.Quantity >= 10 && item.Quantity <= 20)
            {
                item.Discount = item.UnitPrice * item.Quantity * 0.20m;
            }
            else if (item.Quantity >= 4)
            {
                item.Discount = item.UnitPrice * item.Quantity * 0.10m;
            }
            else
            {
                item.Discount = 0;
            }
        }

        sale.CalculateTotal();
    }
}
