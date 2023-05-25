namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee []employee = new Employee[]
            {
                new Employee {Id=1, Name="arwa", gender='F',TotalSale=78452},
                new Employee {Id=2,Name= "alaina", gender='F', TotalSale=35431},
                 new Employee {Id=3,Name= "shrooq", gender='F', TotalSale=5431}
            };


            Report report = new Report();
            report.ProcessEmployee(employee, "total sales more than 60k", (emp) => emp.TotalSale >= 60000m);
            report.ProcessEmployee(employee, "total sales between 30k and 60k", (emp) => emp.TotalSale >= 30000m && emp.TotalSale <= 60000m);
            report.ProcessEmployee(employee, "total sales less than 30k", (emp) => emp.TotalSale < 30000m);
        }
    }
}