using System;

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetIdNumber("123abc");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("456edf");
        sEmployee.SetSalary(60000);

        DisplayEmployeeInfo(hEmployee);
        DisplayEmployeeInfo(sEmployee);


        List<Employee> emp = new List<Employee>();

        emp.Add(hEmployee);
        emp.Add(sEmployee);

        foreach (Employee employees in emp)
        {
            float pay = employees.GetPay();
        }
    }

    public static void DisplayEmployeeInfo(Employee employee)
    {
        float pay = employee.GetPay();

                Console.WriteLine($"{employee.Name} will be paid ${pay}");


    }
}