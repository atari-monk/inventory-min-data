using EFCore.Helper;

namespace Inventory.Min.Data;

public interface IItemRepo 
    : IEFRepositoryAsync<Item>
{
	Task<IEnumerable<Item>> GetItemsAsync();
	Task<IEnumerable<Item>> GetItemsAsync(QueryData queryData);
    Task<IEnumerable<Item>> GetItemsInOneCategoryAsync(int categoryId);
    Task<IEnumerable<Item>> GetItemsExcludingOneStateAsync(int stateId);
    Task<IEnumerable<Item>> GetRelatedItemsExcludingOneStateAsync(int parentId, int stateId);
}