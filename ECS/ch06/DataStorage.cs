using System.IO;

namespace ch06
{
    public class DataStorage
    {
        
        // Save an employee object to a file 
        // named with the Employee name
        // Error handling not shown
        public static void Store(Employee employee)
        {
            // Instantiate a FileStream using FirstNameLastName.dat
            // for the filename. FileMode.Create will force
            // a new file to be created or override an
            // existing file
            FileStream stream = new FileStream(
                employee.FirstName + employee.LastName + ".dat",
                FileMode.Create);

            // Create a StreamWriter object for writing text
            // into the FileStream
            StreamWriter writer = new StreamWriter(stream);

            // Write all the data associated with the employee
            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);

            // Dispose the StreamWriter and its stream
            writer.Dispose();  // Automatically closes the stream
        }


        public static Employee Load(string firstName, string lastName)
        {
            Employee employee = new Employee();

            // Instantiate a FileStream using FirstNameLastName.dat
            // for the filename. FileMode.Open will open
            // an existing file or else report an error
            FileStream stream = new FileStream(
                firstName + lastName + ".dat", FileMode.Open);

            // Create a StreamReader for reading text from the file
            StreamReader reader = new StreamReader(stream);

            // Read each line from the file and place it into
            // the associated property.
            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.Salary = reader.ReadLine();

            // Dispose the StreamReader and its Stream
            reader.Dispose(); // Automatically closes the stream

            return employee;
        }
    }
}