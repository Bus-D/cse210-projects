class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public Address() { }
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, \n{_country}";
    }

    public bool IsInUSA()
    {
        bool isUSA = false;

        if (_country == "USA" || _country == "United States of America")
        {
            isUSA = true;
        }

        return isUSA;
    }

}