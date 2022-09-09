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
    private readonly IStateRepo state;

    public IItemRepo Item => item;
    public ICategoryRepo Category => category;
    public ICurrencyRepo Currency => currency;
    public IStateRepo State => state;

    public InventoryUnitOfWork(
        TContext context
        , IItemRepo item
        , ICategoryRepo category
        , ICurrencyRepo currency
        , IStateRepo state)
            : base(context)
    {
        this.item = item;
        this.category = category;
        this.currency = currency;
        this.state = state;
        ArgumentNullException.ThrowIfNull(this.item);
        ArgumentNullException.ThrowIfNull(this.category);
        ArgumentNullException.ThrowIfNull(this.currency);
        ArgumentNullException.ThrowIfNull(this.state);
    }
}