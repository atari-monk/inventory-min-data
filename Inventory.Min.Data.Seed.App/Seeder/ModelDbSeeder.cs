namespace Inventory.Min.Data.Seed.App;

public class ModelDbSeeder
    : InventorySeeder
{
    protected override Dictionary<string, object> CreateData()
    {
        return new Dictionary<string, object>()
        {
              { GetKey(Category, 1), new Category { Name = "Stock" } }
            , { GetKey(Currency, 1), new Currency { Name = "PLN" } }
            , { GetKey(Unit, 1), new Unit { Name = "cm", Description = "Centimetre" } }
            , { GetKey(Unit, 2), new Unit { Name = "m", Description = "Metre" } }
            , { GetKey(Unit, 3), new Unit { Name = "kg", Description = "Kilogram" } }
            , { GetKey(Unit, 4), new Unit { Name = "l", Description = "Litre" } }
            , { GetKey(Tag, 1), new Tag { Name = "Cabin" } }
            , { GetKey(State, 1), new State { Name = "Plan" } }
            , { GetKey(State, 2), new State { Name = "In storage" } }
            , { GetKey(State, 3), new State { Name = "In use" } }
            , { GetKey(State, 4), new State { Name = "Depleted" } }
        };
    }

    public async Task Seed()
    {
        try
        {
            Enumerable.Range(1, 1).ToList().ForEach(i => SeedCategory(Category + i));
            Enumerable.Range(1, 1).ToList().ForEach(i => SeedCurrency(Currency + i));
            Enumerable.Range(1, 4).ToList().ForEach(i => SeedUnit(Unit + i));
            Enumerable.Range(1, 1).ToList().ForEach(i => SeedTag(Tag + i));
            Enumerable.Range(1, 4).ToList().ForEach(i => SeedState(State + i));
            await Context.SaveChangesAsync();
        }
        finally
        {
            await Context.DisposeAsync();
        }
    }
}