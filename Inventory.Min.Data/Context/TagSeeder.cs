using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class TagSeeder
    : Seeder
{
    public override void Seed(ModelBuilder builder)
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
}