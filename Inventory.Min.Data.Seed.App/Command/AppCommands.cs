using CommandDotNet;

namespace Inventory.Min.Data.Seed.App;

[Command("seed")]
public class AppCommands
{
    [Command("testdb")]
    public async Task SeedTestDb()
    {
        Console.WriteLine("Seed TestDb");
        var seeder = new TestDbSeeder();
        await seeder.Seed();
    }

    [Command("fooddb")]
    public async Task SeedFoodDb()
    {
        Console.WriteLine("Seed FoodDb");
        var seeder = new FoodDbSeeder();
        await seeder.Seed();
    }
}