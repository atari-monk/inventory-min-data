using System.Linq.Expressions;
using EFCore.Helper;

namespace Inventory.Min.Data;

public class ItemRepo
    : EFRepository<Item, InventoryDbContext>
    , IItemRepo
{
    public ItemRepo(InventoryDbContext context)
        : base(context)
    {
    }

    public IEnumerable<Item> GetItem(
        Expression<Func<Item, bool>>? filter)
    {
        return Get(
            filter
            , orderBy: (items) => items
                .OrderBy((item) => item.PurchaseDate)
                .ThenBy((item) => item.PurchasePrice));
    }
}