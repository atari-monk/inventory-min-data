using EFCore.Helper;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class InventoryUnitOfWork<TContext>
    : UnitOfWorkAsync
        , IInventoryUnitOfWork
    where TContext : DbContext
{
    private readonly IItemRepo item;

    public IItemRepo Item => item;

    public InventoryUnitOfWork(
        TContext context
        , IItemRepo item)
            : base(context)
    {
        this.item = item;
        ArgumentNullException.ThrowIfNull(this.item);
    }
}