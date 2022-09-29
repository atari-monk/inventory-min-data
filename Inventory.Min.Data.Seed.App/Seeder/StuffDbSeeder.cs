namespace Inventory.Min.Data.Seed.App;

public class StuffDbSeeder
    : InventorySeeder
{
    protected override Dictionary<string, object> CreateData()
    {
        return new Dictionary<string, object>()
        {
              { GetKey(Category, 1), new Category { Name = "Computer" } }
            , { GetKey(Category, 2), new Category { Name = "Electronics" } }
            , { GetKey(Category, 3), new Category { Name = "Container" } }
            , { GetKey(Category, 4), new Category { Name = "Old Pc component" } }
            , { GetKey(Currency, 1), new Currency { Name = "PLN" } }
            , { GetKey(Unit, 1), new Unit { Name = "cm", Description = "Centimetre" } }
            , { GetKey(Unit, 2), new Unit { Name = "m", Description = "Metre" } }
            , { GetKey(Unit, 3), new Unit { Name = "kg", Description = "Kilogram" } }
            , { GetKey(Unit, 4), new Unit { Name = "l", Description = "Litre" } }
            , { GetKey(Tag, 1), new Tag { Name = "Flat" } }
            , { GetKey(State, 1), new State { Name = "In storage" } }
            , { GetKey(State, 2), new State { Name = "In use" } }
            , { GetKey(State, 3), new State { Name = "Broken" } }
            , { GetKey(State, 4), new State { Name = "Disposed Off" } }
        };
    }

    public async Task Seed()
    {
        try
        {
            Enumerable.Range(1, 4).ToList().ForEach(i => SeedCategory(GetKey(Category, i)));
            Enumerable.Range(1, 1).ToList().ForEach(i => SeedCurrency(GetKey(Currency, i)));
            Enumerable.Range(1, 4).ToList().ForEach(i => SeedUnit(GetKey(Unit, i)));
            Enumerable.Range(1, 1).ToList().ForEach(i => SeedTag(GetKey(Tag, i)));
            Enumerable.Range(1, 4).ToList().ForEach(i => SeedState(GetKey(State, i)));
            await Context.SaveChangesAsync();
        }
        finally
        {
            await Context.DisposeAsync();
        }
    }
}