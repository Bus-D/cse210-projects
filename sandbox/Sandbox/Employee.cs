public abstract class Employee
{
    protected string _name;
    protected string _idNumber;

    public Employee()
    {

    }
    
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    public string IdNumber
    {
        get { return _idNumber; }
        set { _idNumber = value; }
    }

    public string SetName(string name)
    {
        Name = name;
        return Name;
    }

    public string SetIdNumber(string idNumber)
    {
        IdNumber = idNumber;
        return IdNumber;
    }

    public abstract float GetPay();
}

