namespace Doodle;

using Entities;

class Program
{

    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: "_myAllowSpecificOrigins", policy =>
            {
                policy.WithOrigins("http://example.com", "http://www.contoso.com");
            });
        });

        var app = builder.Build();

        app.UseCors("_myAllowSpecificOrigins");

        Route(app);
        app.Run();
    }

    public static void Route(WebApplication app)
    {
        List<Person> users = new List<Person>();

        users.Add(new Person() { Name = "kissejau", Role = Roles.Owner });

        app.MapGet("/", () => { return "Doodle welcome page."; });

        app.MapGet("/api/users", () => { return users; });

        app.MapPost("/api/users/add", (Person person) =>
        {
            users.Add(person);
        });
    }

}
