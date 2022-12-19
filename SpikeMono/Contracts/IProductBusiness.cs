using SpikeMonoAPI.Models;

namespace SpikeMonoAPI.Contracts
{
	public interface IProductBusiness
	{
		Product AddProduct(Product newProduct);

		IEnumerable<Product> GetProducts();
	}
}
