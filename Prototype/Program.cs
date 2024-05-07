using Prototype;

ServerConfiguration configuration = new ServerConfiguration();
configuration.FileStorageURL = "http://www.example.com";
configuration.OperationSystem = "Windows Server 2019";
configuration.DBConnect = "Server=.;Database=ExampleDB;Trusted_Connection=True;";
var clone = (ServerConfiguration)configuration.Clone();
Console.WriteLine(clone.GetDetails());

//Ex2

Employee employee = new Employee();
employee.Name = "John Doe";
employee.Role = "Software Developer";
var employeeClone = (Employee)employee.Clone();
Console.WriteLine(employeeClone.GetDetails());