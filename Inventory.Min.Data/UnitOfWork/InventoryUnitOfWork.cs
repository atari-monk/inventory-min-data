using EFCore.Helper;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class InventoryUnitOfWork<TContext>
    : UnitOfWorkAsync
        , IInventoryUnitOfWork
    where TContext : DbContext
{
    private readonly IItemRepo item;
    private readonly ICategoryRepo category;

    public IItemRepo Item => item;
    public ICategoryRepo Category => category;

    public InventoryUnitOfWork(
        TContext context
        , IItemRepo item
        , ICategoryRepo category)
            : base(context)
    {
        this.item = item;
        this.category = category;
        ArgumentNullException.ThrowIfNull(this.item);
        ArgumentNullException.ThrowIfNull(this.category);
    }
}