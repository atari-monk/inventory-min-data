using EFCore.Helper;

namespace Inventory.Min.Data;

public interface IItemRepo 
    : IEFRepositoryAsync<Item>
{
	Task<IEnumerable<Item>> GetItemsAsync();
	Task<IEnumerable<Item>> GetItemsAsync(QueryData queryData);
    Task<IEnumerable<Item>> GetItemsAsync(int categoryId);
}