public class Order
{
  private List<Product> _products;
  private Customer _customer;

  public Order(List<Product> products, Customer customer)
  {
    _customer = customer;
    _products = products;
  }
  public decimal CalculateTotalPrice()
  {
    decimal total = 0;
    foreach(var product in _products)
    {
      total += product.GetTotalCost();
    }

    decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
    total += shippingCost;
    return total;
  }

  public string GetPackingLabel()
  {
    string label  = "Packing Label: ";
    foreach(var product in _products)
  {
    label += $"Product:{product.GetName()}, ID:{product.GetProductId()}";
  }
  return label;
  }

  public string GetShippingLabel()
    {
        return $"Shipping Label:  Name: {_customer.GetName()} Address: {_customer.GetAddress().GetFullAddress()}";
    }
}