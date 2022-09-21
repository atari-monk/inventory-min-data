using EFCore.Helper;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public class ItemRepo<TContext>
    : EFRepositoryAsync<Item, TContext>
        , IItemRepo
            where TContext : DbContext
{
    private readonly Func<IQueryable<Item>, IOrderedQueryable<Item>>? defaultOrderBy;
    private readonly string defaultInclude;
    private readonly QueryData defaultQuery;
    
    public ItemRepo(TContext context)
        : base(context)
    {
        defaultOrderBy
            = (items) => items.OrderBy((item) => item.Id)
                .ThenBy((item) => item.PurchaseDate);
        defaultInclude
            = $"{nameof(Item.Category)},{nameof(Item.State)},{nameof(Item.Parent)}";
        defaultQuery = new QueryData(
            (item) => true
            , defaultOrderBy
            , defaultInclude);
    }

    public async Task<IEnumerable<Item>> GetItemsAsync()
    {
        return await GetAsync(
            defaultQuery.Filter
            , defaultQuery.OrderBy
            , defaultQuery.IncludeProperties);
    }

    public async Task<IEnumerable<Item>> GetItemsAsync(QueryData queryData)
    {
        return await GetAsync(
            queryData.Filter
            , queryData.OrderBy
            , queryData.IncludeProperties);
    }

    public async Task<IEnumerable<Item>> GetItemsAsync(int categoryId)
    {
        var queryData = new QueryData(
            (item) => item.CategoryId == categoryId
            , defaultOrderBy
            , defaultInclude);
        return await GetAsync(
            queryData.Filter
            , queryData.OrderBy
            , queryData.IncludeProperties);
    }
}