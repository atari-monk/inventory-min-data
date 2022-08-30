namespace Inventory.Min.Data;

public class TestSeeder
{
    private readonly InventoryDbContext context;
    private readonly Dictionary<string, object> data;
    private readonly Dictionary<string, object> actions;

    public TestSeeder()
    {
        context = new InventoryDbContext();
        data = CreateData();
        actions = CreateActions();
    }

    private Dictionary<string, object> CreateData()
    {
        return new Dictionary<string, object>()
        {
            { "Category-1", new Category { Name = "Food" } }
            , { "Currency-1", new Currency { Name = "PLN" } }
            , { "Unit-1", new Unit { Name = "cm", Description = "centimeter" } }
            , { "Unit-2", new Unit { Name = "m", Description = "meter" } }
            , { "Unit-3", new Unit { Name = "ml", Description = "milliliter" } }
            , { "Unit-4", new Unit { Name = "l", Description = "liter" } }
            , { "Unit-5", new Unit { Name = "kg" } }
            , { "Tag-1", new Tag { Name = "Groceries 08.2022" } }
            , { "State-1", new State { Name = "In Storage" } }
        };
    }

    private Dictionary<string, object> CreateActions()
    {
        return new Dictionary<string, object>()
        {
            { 
                "Category"
                , new SeedAction<InventoryDbContext, Category>(
                    (context, entity) => { return context.Category?.FirstOrDefault(c => c.Name == entity.Name); }
                    , (context, entity) => context.Category?.Add(entity))
            }
            , { 
                "Currency"
                , new SeedAction<InventoryDbContext, Currency>(
                    (context, entity) => { return context.Currency?.FirstOrDefault(c => c.Name == entity.Name); }
                    , (context, entity) => context.Currency?.Add(entity))
            }
            , { 
                "Unit"
                , new SeedAction<InventoryDbContext, Unit>(
                    (context, entity) => { return context.Unit?.FirstOrDefault(c => c.Name == entity.Name); }
                    , (context, entity) => context.Unit?.Add(entity))
            }
            , { 
                "Tag"
                , new SeedAction<InventoryDbContext, Tag>(
                    (context, entity) => { return context.Tag?.FirstOrDefault(c => c.Name == entity.Name); }
                    , (context, entity) => context.Tag?.Add(entity))
            }
            , {
                "State"
                , new SeedAction<InventoryDbContext, State>(
                    (context, entity) => { return context.State?.FirstOrDefault(c => c.Name == entity.Name); }
                    , (context, entity) => context.State?.Add(entity))
            }
        };
    }

    private TType GetData<TType>(string key)
    {
        return (TType)data[key];
    }

    private TType GetAction<TType>(string key)
    {
        return (TType)actions[key];
    }

    public async Task<TResult> InvokeAction<TResult>(Func<Task<TResult>> action)
    {
        return await action();
    }

    private void SeedEntity<TContext, TEntity>(
        TContext context
        , string key
        , SeedAction<TContext, TEntity> actions)
    {
        var entity = GetData<TEntity>(key);
        var entityDb = actions.GetDbEntity!.Invoke(context, entity);
        if (entityDb == null)
        {
            actions.AddEntity!(context, entity);
        }
    }

    private void SeedCategory(string key)
    {
        SeedEntity<InventoryDbContext, Category>(
                context
                , key
                , GetAction<SeedAction<InventoryDbContext, Category>>("Category"));
    }

    private void SeedCurrency(string key)
    {
        SeedEntity<InventoryDbContext, Currency>(
            context
            , key
            , GetAction<SeedAction<InventoryDbContext, Currency>>("Currency"));
    }

    private void SeedUnit(string key)
    {
        SeedEntity<InventoryDbContext, Unit>(
            context
            , key
            , GetAction<SeedAction<InventoryDbContext, Unit>>("Unit"));
    }

    private void SeedTag(string key)
    {
        SeedEntity<InventoryDbContext, Tag>(
            context
            , key
            , GetAction<SeedAction<InventoryDbContext, Tag>>("Tag"));
    }

    private void SeedState(string key)
    {
        SeedEntity<InventoryDbContext, State>(
            context
            , key
            , GetAction<SeedAction<InventoryDbContext, State>>("State"));
    }

    public async Task Seed()
    {
        try
        {
            SeedCategory("Category-1");
            SeedCurrency("Currency-1");
            SeedUnit("Unit-1");
            SeedUnit("Unit-2");
            SeedUnit("Unit-3");
            SeedUnit("Unit-4");
            SeedUnit("Unit-5");
            SeedTag("Tag-1");
            SeedState("State-1");
            await context.SaveChangesAsync();
        }
        finally
        {
            await context.DisposeAsync();
        }
    }
}