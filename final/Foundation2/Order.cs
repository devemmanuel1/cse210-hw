public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double totalCost = 0;
        double shippingCost = 5;
        if (!_customer.IsUsaAddress()) 
        {
            shippingCost = 35;
        }

        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }

        totalCost += shippingCost;
        return totalCost;
    }

    public string ToStringPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"\n   Product ID: {product.GetProductId()}   Name: {product.GetName()}";
        }

        return packingLabel;
    }

    public string ToStringShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += $"   {_customer.GetName()}\n{_customer.GetAddress()}";
        return shippingLabel;
    }
}