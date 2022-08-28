using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class StateSeeder
    : Seeder
{
    public override void Seed(ModelBuilder builder)
    {
        builder.Entity<State>()
            .HasData(
                GetEntity(
                    1
                    , "In storage")
                , GetEntity(
                    2
                    , "In use")
                , GetEntity(
                    3
                    , "Depleted"));
    }
}