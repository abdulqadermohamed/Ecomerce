namespace Core.Interface
{
    public interface IproductRepos
    {
        Task <product> GetProductByIdasync(int id);
       
         Task<IReadOnlyList<Product>> GetProductsasync();
    }
}