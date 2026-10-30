namespace App.Repositories.Products
{
    internal interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetTopPriceProductsAsync(int count);
    }
}
