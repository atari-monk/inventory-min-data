using EFCore.Helper;

namespace Inventory.Min.Data;

public interface IInventoryUnitOfWork 
	: IUnitOfWork
{
	IItemRepo Item { get; }
}