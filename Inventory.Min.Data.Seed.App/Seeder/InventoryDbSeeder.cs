namespace Inventory.Min.Data.Seed.App;

public class InventoryDbSeeder
    : InventorySeeder
{
    protected override Dictionary<string, object> CreateData()
    {
        return new Dictionary<string, object>()
        {
              { Category + "1", new Category { Name = "Container" } }
            , { Category + "2", new Category { Name = "Clothing" } }
            , { Currency + "1", new Currency { Name = "PLN" } }
            , { Currency + "2", new Currency { Name = "EUR" } }
            , { Currency + "3", new Currency { Name = "USD" } }
            , { Unit + "1", new Unit { Name = "cm", Description = "Centimetre" } }
            , { Unit + "2", new Unit { Name = "l", Description = "Litre" } }
            , { Unit + "3", new Unit { Name = "g", Description = "Gram" } }
            , { Unit + "4", new Unit { Name = "kg", Description = "Kilogram" } }
            //, { Tag + "1", new Tag { Name = "" } }
            , { State + "1", new State { Name = "In storage" } }
            , { State + "2", new State { Name = "In use" } }
            , { State + "3", new State { Name = "Depleted" } }
            , { State + "4", new State { Name = "In wash" } }
        };
    }

    public virtual async Task Seed()
    {
        try
        {
            for (int i = 1; i <= 2; i++)
            {
                SeedCategory(Category + i);
            }
            for (int i = 1; i <= 3; i++)
            {
                SeedCurrency(Currency + i);
            }
            for (int i = 1; i <= 4; i++)
            {
                SeedUnit(Unit + i);
            }
            // for (int i = 1; i <= 1; i++)
            // {
            //     SeedTag(Tag + i);
            // }
            for (int i = 1; i <= 4; i++)
            {
                SeedState(State + i);
            }
            await Context.SaveChangesAsync();
        }
        finally
        {
            await Context.DisposeAsync();
        }
    }
}