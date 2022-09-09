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
    private readonly ICurrencyRepo currency;

    public IItemRepo Item => item;
    public ICategoryRepo Category => category;
    public ICurrencyRepo Currency => currency;

    public InventoryUnitOfWork(
        TContext context
        , IItemRepo item
        , ICategoryRepo category
        , ICurrencyRepo currency)
            : base(context)
    {
        this.item = item;
        this.category = category;
        this.currency = currency;
        ArgumentNullException.ThrowIfNull(this.item);
        ArgumentNullException.ThrowIfNull(this.category);
        ArgumentNullException.ThrowIfNull(this.currency);
    }
}