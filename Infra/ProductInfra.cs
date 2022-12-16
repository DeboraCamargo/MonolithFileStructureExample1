using SpikeMonoAPI.Contracts;
using SpikeMonoAPI.Models;

namespace SpikeMonoAPI.Infra
{
	public class ProductInfra : IProductInfra
	{
		public Product AddProduct(Product newProduct)
		{
			return newProduct;
		}

		public IEnumerable<Product> GetProducts()
		{
			return new List<Product>()
			{
				new()
				{
					Name = "Toddy",
					Price = 50f,
				}
			};
		}
	}
}
