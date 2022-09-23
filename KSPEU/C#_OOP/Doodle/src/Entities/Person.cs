namespace Doodle.Entities;

enum Roles{
    User,
    Manager,
    Owner
}

class Person
{
    public Guid Id {get; } = Guid.NewGuid();
    public string? Name {get; set; }
    public  Roles Role {get; set; }
    public DateTime RegDate {get; } = DateTime.Now;

}