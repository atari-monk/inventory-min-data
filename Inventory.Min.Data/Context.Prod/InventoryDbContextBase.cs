using EFCore.Helper;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data.Context.Prod;

public abstract class InventoryDbContextBase
    : ProdDbContext
{
    public InventoryDbContextBase(DbContextOptions<InventoryDbContextBase> options)
        : base(options)
    {
    }

    protected InventoryDbContextBase(DbContextOptions options)
        : base(options)
    {
    }

	public DbSet<Category>? Category { get; set; }
	public DbSet<Currency>? Currency { get; set; }
	public DbSet<Item>? Item { get; set; }
	public DbSet<State>? State { get; set; }
	public DbSet<Tag>? Tag { get; set; }
	public DbSet<Unit>? Unit { get; set; }
}