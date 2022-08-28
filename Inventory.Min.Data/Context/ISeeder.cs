using Microsoft.EntityFrameworkCore;

namespace Inventory.Min.Data;

public interface ISeeder
{
    void Seed(ModelBuilder builder);
}