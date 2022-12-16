using SpikeMonoAPI.Models;

namespace SpikeMonoAPI.Contracts
{
    public interface IProductInfra
    {
        Product AddProduct(Product newProduct);

        IEnumerable<Product> GetProducts();
    }
}
