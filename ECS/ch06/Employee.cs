using System;

namespace ch06
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary = "Not enough";

        public string GetName()
        {
            return $"{FirstName}  {LastName}";
        }

        public void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine(
                $"Name changed to '{this.GetName()}'");
        }

        public void Save()
        {
            DataStorage.Store(this);
        }
    }
}
    