class Order
{
    private List<Product> _products = new List<Product>();
    private Product product;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void GetPackingLabel()
    {
        Console.WriteLine($"Product Name: {product.GetName}\nProduct ID: {product.GetId}");
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"Name: {_customer.GetCustomerName}\nAddress: {_customer.GetAddress}");
    }
    
    public string GetTotalPrice()
    {
        bool usa = _customer.LivesInUSA();
        double totalPrice = 0;

        if (usa)
        {
            totalPrice = product.GetTotalCost() + 5;
        }
        else
        {
            totalPrice = product.GetTotalCost() + 35;
        }

        return $"${totalPrice}";
    }
}