class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetCustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}