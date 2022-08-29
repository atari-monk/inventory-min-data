using EFCore.Helper;

namespace Inventory.Min.Data;

public interface IInventoryUnitOfWork 
	: IUnitOfWorkAsync
{
	IItemRepo Item { get; }
}