using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public abstract class InventoryDbContextSeeder
    : InventoryDbContextBase
{
    protected override void SeedData(ModelBuilder builder)
    {
        builder.Entity<Category>()
            .HasData(
                GetEntity(
                    1
                    , "Food")
                    );
        builder.Entity<Currency>()
            .HasData(
                GetEntity(
                    1
                    , "PLN")
                    );
        builder.Entity<State>()
            .HasData(
                GetEntity(
                    1
                    , "Very good"
                    , "Sold")
                    );
        builder.Entity<Tag>()
            .HasData(
                GetEntity(
                    1
                    , "Preserves")
                    );
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
                    );   
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
}