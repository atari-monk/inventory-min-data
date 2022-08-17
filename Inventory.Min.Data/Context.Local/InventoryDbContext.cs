using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data.Context.Local;

public class InventoryDbContext
    : InventoryDbContextSeeder
{
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
        : base(options)
    {
    }

    protected InventoryDbContext(DbContextOptions options)
        : base(options)
    {
    }
}