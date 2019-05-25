using System;
//using ch06.Employee;

namespace ch06
{
    class Program
    {
        static void Main()
        {
            
            Employee employee1;

            Employee employee2 = new Employee();
            employee2.SetName("Inigo", "Montoya");
            employee2.Save();

            // Modify employee2 after saving
            IncreaseSalary(employee2);
            employee2.Save();

            // Load employee1 from the saved version of employee2
            employee1 = DataStorage.Load("Inigo", "Montoya");

            Console.WriteLine(
                $"{ employee1.GetName() }: { employee1.Salary }");
            
//            Employee employee1 = new Employee();
//            Employee employee2;
//            employee2 = new Employee();
//
//            employee1.FirstName = "Inigo";
//            employee1.LastName = "Montoya";
//            employee1.Salary = "Too Little";
//            IncreaseSalary(employee1);
//            Console.WriteLine(
//                "{0} {1}: {2}",
//                employee1.FirstName,
//                employee1.LastName,
//                employee1.Salary);
//            
//            
//            employee2.SetName("Inigo", "Montoya");
//            employee2.Save();
//
//            // Modify employee2 after saving
//            IncreaseSalary(employee2);
//
//            // Load employee1 from the saved version of employee2
//            employee1 = DataStorage.Load("Inigo", "Montoya");
//
//            Console.WriteLine(
//                $"{ employee1.GetName() }: { employee1.Salary }");
            
            
        }
        
        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }
}