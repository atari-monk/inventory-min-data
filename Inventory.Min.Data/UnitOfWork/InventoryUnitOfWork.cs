using EFCore.Helper;

namespace Inventory.Min.Data;

public class InventoryUnitOfWork
    : UnitOfWork
        , IInventoryUnitOfWork
{
    private readonly IItemRepo item;

    public IItemRepo Item => item;

    public InventoryUnitOfWork(
        InventoryDbContext context
        , IItemRepo item)
            : base(context)
    {
        this.item = item;
        ArgumentNullException.ThrowIfNull(this.item);
    }
}