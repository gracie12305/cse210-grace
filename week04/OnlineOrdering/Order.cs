using System.Collections.Generic;
class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double TotalCost()
    {
        double productCost = 0;
        foreach (var product in _products)
        {
            productCost += product.TotalCost();
        }

        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return productCost + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label.Trim();
    }

    public string ShippingLabel()
    {
        string customerInfo = $"{_customer.Name}\n{_customer.Address.GetFullAddress()}";
        return customerInfo;
    }
}

