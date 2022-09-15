namespace Inventory.Min.Data.Seed.App;

public class TestDbSeeder
    : InventorySeeder
{
    protected override Dictionary<string, object> CreateData()
    {
        return new Dictionary<string, object>()
        {
            { Category + "1", new Category { Name = "Food" } }
            , { Category + "2", new Category { Name = "Pasta" } }
            , { Currency + "1", new Currency { Name = "PLN" } }
            , { Unit + "1", new Unit { Name = "cm", Description = "centimeter" } }
            , { Unit + "2", new Unit { Name = "m", Description = "meter" } }
            , { Unit + "3", new Unit { Name = "ml", Description = "milliliter" } }
            , { Unit + "4", new Unit { Name = "l", Description = "liter" } }
            , { Unit + "5", new Unit { Name = "kg" } }
            , { Tag + "1", new Tag { Name = "Groceries 08.2022" } }
            , { State + "1", new State { Name = "In Storage" } }
        };
    }

    public async Task Seed()
    {
        try
        {
            SeedCategory(Category + "1");
            SeedCurrency(Currency + "1");
            SeedUnit(Unit + "1");
            SeedUnit(Unit + "2");
            SeedUnit(Unit + "3");
            SeedUnit(Unit + "4");
            SeedUnit(Unit + "5");
            SeedTag(Tag + "1");
            SeedState(State + "1");
            await Context.SaveChangesAsync();
        }
        finally
        {
            await Context.DisposeAsync();
        }
    }
}