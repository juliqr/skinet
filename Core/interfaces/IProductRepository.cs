using System.Collections.Generic;
using Core.Entities;

namespace Core.interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductsBrandAsync();
        Task<IReadOnlyList<ProductType>> GetProductsTypesAsync();
    }
}