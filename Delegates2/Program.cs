using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        List<Employee> empList = new();

        empList.Add(new Employee() { Id = 101, Name = "Abhishek", Salary = 5000,Experience = 5});
        empList.Add(new Employee() { Id = 102, Name = "Prience", Salary = 4000, Experience = 3 });
        empList.Add(new Employee() { Id = 103, Name = "Vinay", Salary = 8000, Experience = 7 });
        empList.Add(new Employee() { Id = 104, Name = "Anshul", Salary = 6000, Experience = 6 });

        // IsPromotable isPromotable = new IsPromotable(Promote);
        //insted of making insatnce of class we using the lamda expression
        //  Employee.PromoteEmployee(empList,isPromotable);

        Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);   // This is lamda expression

    }
    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}

delegate bool IsPromotable(Employee emp);
class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Salary { get; set; }

    public int Experience { get; set; }


    public static void PromoteEmployee(List<Employee> employeelist,IsPromotable isEligiblePromote)
    {
        foreach (Employee employee in employeelist)
        {
            if (isEligiblePromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}
