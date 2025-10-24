class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product() { }
    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName
    {
        get { return _productName; }
        set { _productName = value; }
    }

    public int GetId
    {
        get { return _productId; }
        set { _productId = value; }
    }

   public double GetTotalCost()
    {
        return _price * _quantity;
    }
}