using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class CategorySeeder
    : Seeder
{
    public override void Seed(ModelBuilder builder)
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

    private object GetCategory(
        int id
        , string name
        , string? description = default
        , int? parentId = default)
    {
        return new
        {
            Id = id
            ,
            Name = name
            ,
            Description = description
            ,
            ParentId = parentId
            ,
            CreatedDate = DateTime.Now
            ,
            UpdatedDate = DateTime.Now
        };
    }
}