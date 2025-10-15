public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private float _hoursWorked = 0;

    public float PayRate
    {
        get { return _payRate; }
        set { _payRate = value; }
    }

    public float HoursWorked
    {
        get { return _hoursWorked; }
        set { _hoursWorked = value; }
    }

    public float SetPayRate(float payRate)
    {
        PayRate = payRate;
        return PayRate;
    }

    public float SetHoursWorked(float hoursWorked)
    {
        HoursWorked = hoursWorked;
        return HoursWorked;
    }

    public override float GetPay()
    {
        return _hoursWorked * _payRate;
    }
}