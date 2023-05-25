namespace DelegateEmolyee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] employee = new Employee[]
           {
                new Employee {Name="arwa", age=24,Salary=5000,TotalSale=200000},
                new Employee {Name="maria", age=34,Salary=6000,TotalSale=3000},
                 new Employee {Name="hajer", age=44,Salary=4000,TotalSale=4000}
           };

            Reports reports = new Reports();
            reports.ProcessEmployee(employee, "total sales more than 60k", (emp) => emp.TotalSale >= 6000m);

            reports.ProcessEmployee(employee, "age more than 30", (emp) => emp.age >= 30);

            reports.ProcessEmployee(employee, "salary more than 5000", (emp) => emp.Salary >= 5000);

        }
    }
}