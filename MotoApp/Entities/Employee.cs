namespace MotoApp.Entities
{
    public class Employee : EnityBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName {FirstName}";
    }
}
