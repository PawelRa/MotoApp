namespace MotoApp.Entities
{
    public class Employee : EnityBase
    {
        public Employee() { }

        public Employee(string name) { }

        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName {FirstName}";
    }
}
