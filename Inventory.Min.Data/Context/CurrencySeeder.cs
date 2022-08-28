using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class CurrencySeeder
    : Seeder
{
    public override void Seed(ModelBuilder builder)
    {
        builder.Entity<Currency>()
            .HasData(
                GetEntity(
                    1
                    , "PLN")
                , GetEntity(
                    2
                    , "EUR")
                , GetEntity(
                    3
                    , "USD"));
    }
}