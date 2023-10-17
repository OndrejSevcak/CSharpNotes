using System.Text;

Person person = new Person
{
    FirstName = "Larry",
    LastName = "Page",
    Age = 36,
    Email = "larry@google.com",
    IsClubMember = true
};

Console.WriteLine(person.ToString());

//Id: 0
//FirstName: Larry
//LastName : Page
//Age : 36
//Email: larry @google.com
//IsClubMember : True

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public bool IsClubMember { get; set; }

    public override string ToString()
    {
        return GetType()
              .GetProperties()
              .Select(prop => (prop.Name, Value: prop.GetValue(this, null) ?? "(null)"))
              .Aggregate(
                new StringBuilder(),
                (sb, prop) => sb.AppendLine($"{prop.Name} : {prop.Value}"),
                sb => sb.ToString());
    }
}