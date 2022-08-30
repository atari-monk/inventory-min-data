namespace Inventory.Min.Data;

public class TestSeeder
{
    private Dictionary<string, object> lexicon = new Dictionary<string, object>()
    {
        { "Category-1", new Category{ Name = "Food", Description = "Organic Matter" } }
        , { "Currency-1", new Currency{ Name = "PLN", Description = "Polish złoty" } }
    };

    private TType Get<TType>(string key)
    {
        return (TType)lexicon[key];
    }

    public void Seed()
    {
        var categoryActions = new SeedAction<InventoryDbContext, Category>(
            (context, entity) => { return context.Category?.FirstOrDefault(c => c.Name == entity.Name); }
            , (context, entity) => context.Category?.Add(entity)
        );
        var currencyActions = new SeedAction<InventoryDbContext, Currency>(
            (context, entity) => { return context.Currency?.FirstOrDefault(c => c.Name == entity.Name); }
            , (context, entity) => context.Currency?.Add(entity)
        );
        using (var context = new InventoryDbContext())
        {
            SeedEntity<InventoryDbContext, Category>(
                context
                , "Category-1"
                , categoryActions);
            SeedEntity<InventoryDbContext, Currency>(
                context
                , "Currency-1"
                , currencyActions);
            context.SaveChanges();
        }
    }

    private void SeedEntity<TContext, TEntity>(
        TContext context
        , string key
        , SeedAction<TContext, TEntity> actions)
    {
        var entity = Get<TEntity>(key);
        var entityDb = actions.GetDbEntity!.Invoke(context, entity);
        if (entityDb == null)
        {
            actions.AddEntity!(context, entity);
        }
    }
}