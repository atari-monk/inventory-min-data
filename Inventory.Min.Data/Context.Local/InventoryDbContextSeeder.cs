using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data.Context.Local;

public abstract class InventoryDbContextSeeder
    : InventoryDbContextBase
{
    public InventoryDbContextSeeder(DbContextOptions<InventoryDbContextSeeder> options)
        : base(options)
    {
    }

    protected InventoryDbContextSeeder(DbContextOptions options)
        : base(options)
    {
    }

    protected override void SeedData(ModelBuilder builder)
    {
        SeedCategory(builder);
        SeedCurrency(builder);
        SeedState(builder);
        SeedTag(builder);
        SeedUnit(builder);
    }

    private void SeedCategory(ModelBuilder builder)
    {
        builder.Entity<Category>()
            .HasData(
                GetEntity(
                    1
                    , "Food")
                , GetEntity(
                    2
                    , "Furniture")
                , GetCategory(
                    3
                    , "Pasta"
                    , default
                    , 1));
    }

    private void SeedCurrency(ModelBuilder builder)
    {
        builder.Entity<Currency>()
            .HasData(
                GetEntity(
                    1
                    , "PLN"));
    }

    private void SeedState(ModelBuilder builder)
    {
        builder.Entity<State>()
            .HasData(
                GetEntity(
                    1
                    , "Resource depleted"));
    }

    private void SeedTag(ModelBuilder builder)
    {
        builder.Entity<Tag>()
            .HasData(
                GetEntity(
                    1
                    , "Preserves")
                , GetEntity(
                    2
                    , "Shopping 08.2022"));
    }

    private void SeedUnit(ModelBuilder builder)
    {
        builder.Entity<Unit>()
            .HasData(
                GetEntity(
                    1
                    , "cm"
                    , "Centimetre")
                , GetEntity(
                    2
                    , "l"
                    , "Litre")
                , GetEntity(
                    3
                    , "g"
                    , "Gram")
                 , GetEntity(
                    4
                    , "kg"
                    , "Kilogram"));
    }

    private object GetEntity(
        int id
        , string name
        , string? description = default)
    {
        return new 
        { 
            Id = id
            , Name = name
            , Description = description
            , CreatedDate = DateTime.Now
            , UpdatedDate = DateTime.Now
        };
    }

    private object GetCategory(
        int id
        , string name
        , string? description = default
        , int? parentId = default)
    {
        return new 
        { 
            Id = id
            , Name = name
            , Description = description
            , ParentId = parentId
            , CreatedDate = DateTime.Now
            , UpdatedDate = DateTime.Now
        };
    }
}