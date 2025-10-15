public class SalaryEmployee : Employee
{
    private float _salary = 0;

    public float Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }

    public float SetSalary(float salary)
    {
        Salary = salary;
        return Salary;
    }

    public override float GetPay()
    {
        return Salary / 12;
    }
}