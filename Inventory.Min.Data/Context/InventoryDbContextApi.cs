using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class InventoryDbContextApi
    : InventoryDbContextSeeder
{
    public InventoryDbContextApi()
        : base()
    {
        
    }

    public InventoryDbContextApi(DbContextOptions<InventoryDbContext> options)
        : base(options)
    {
    }

    protected InventoryDbContextApi(DbContextOptions options)
        : base(options)
    {
    }

    protected override void SetConfig(DbContextOptionsBuilder builder)
    {
    }
}