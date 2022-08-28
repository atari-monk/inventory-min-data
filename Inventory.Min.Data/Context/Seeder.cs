using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public abstract class Seeder
    : ISeeder
{
    public abstract void Seed(ModelBuilder builder);

    protected object GetEntity(
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