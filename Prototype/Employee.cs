namespace Prototype
{
    public class Employee : ICloneable
    {
        public string Name { get; set; }
        public string Role { get; set; }
        private string Salary { get; set; }

        public Employee()
        {
            this.Salary = "1000";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetDetails()
        {
            return $"Name: {Name}, Role: {Role}, Salary: {Salary}";
        }
    }
}