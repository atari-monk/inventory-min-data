using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class InventoryDbContext
    : InventoryDbContextSeeder
{
    public InventoryDbContext()
        : base()
    {
        
    }

    public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
        : base(options)
    {
    }

    protected InventoryDbContext(DbContextOptions options)
        : base(options)
    {
    }
}