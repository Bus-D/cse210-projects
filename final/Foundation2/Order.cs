class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product p in _products)
        {
            label += $"Product ID: {p.GetId} Product Name: {p.GetName}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetCustomerName}\nAddress: {_customer.GetAddress()}";
    }
    
    public string GetTotalPrice()
    {
        bool usa = _customer.LivesInUSA();
        double totalPrice = 0;

        foreach (Product p in _products)
        {
            totalPrice += p.GetTotalCost();
        }

        if (usa)
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return $"${totalPrice}";
    }
}