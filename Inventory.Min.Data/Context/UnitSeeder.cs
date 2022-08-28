using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class UnitSeeder
    : Seeder
{
    public override void Seed(ModelBuilder builder)
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
}