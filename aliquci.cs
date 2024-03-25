public class Employee
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private int _salary;

    public Employee(int id, string firstName, string lastName, int salary)
    {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
        _salary = salary;
    }

    public string GetFullName()
    {
        return _firstName + " " + _lastName;
    }

    // Add other methods and properties as needed
}
