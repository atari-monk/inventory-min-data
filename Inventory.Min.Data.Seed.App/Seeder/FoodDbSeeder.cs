namespace Inventory.Min.Data.Seed.App;

public class FoodDbSeeder
    : InventorySeeder
{
    protected override Dictionary<string, object> CreateData()
    {
        return new Dictionary<string, object>()
        {
              { Category + "1", new Category { Id = 1, Name = "Food" } }
            , { Category + "2", new Category { Id = 2, Name = "Furniture" } }
            , { Category + "3", new Category { Id = 3, Name = "Pasta" } }
            , { Currency + "1", new Currency { Id = 1, Name = "PLN" } }
            , { Currency + "2", new Currency { Id = 2, Name = "EUR" } }
            , { Currency + "3", new Currency { Id = 3, Name = "USD" } }
            , { Unit + "1", new Unit { Id = 1, Name = "cm", Description = "Centimetre" } }
            , { Unit + "2", new Unit { Id = 2, Name = "l", Description = "Litre" } }
            , { Unit + "3", new Unit { Id = 3, Name = "g", Description = "Gram" } }
            , { Unit + "4", new Unit { Id = 4, Name = "kg", Description = "Kilogram" } }
            , { Tag + "1", new Tag { Name = "Preserves" } }
            , { State + "1", new State { Id = 1, Name = "In storage" } }
            , { State + "2", new State { Id = 2, Name = "In use" } }
            , { State + "3", new State { Id = 3, Name = "Depleted" } }
        };
    }

    public async Task Seed()
    {
        try
        {
            SeedCategory(Category + "1");
            SeedCategory(Category + "2");
            SeedCategory(Category + "3");
            SeedCurrency(Currency + "1");
            SeedCurrency(Currency + "2");
            SeedCurrency(Currency + "3");
            SeedUnit(Unit + "1");
            SeedUnit(Unit + "2");
            SeedUnit(Unit + "3");
            SeedUnit(Unit + "4");
            SeedTag(Tag + "1");
            SeedState(State + "1");
            SeedState(State + "2");
            SeedState(State + "3");
            await Context.SaveChangesAsync();
        }
        finally
        {
            await Context.DisposeAsync();
        }
    }
}