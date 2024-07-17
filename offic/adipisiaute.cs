public class Employee : IEmployee
{
    public string FullName { get; set; }
    public int Id { get; set; }

    public Employee(string fullName, int id)
    {
        FullName = fullName;
        Id = id;
    }
}
