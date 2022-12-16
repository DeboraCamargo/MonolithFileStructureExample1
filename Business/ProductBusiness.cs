using SpikeMonoAPI.Contracts;
using SpikeMonoAPI.Models;

namespace SpikeMonoAPI.Business
{
	public class ProductBusiness : IProductBusiness
	{
		private readonly IProductInfra _productInfra;

		public ProductBusiness(IProductInfra productInfra)
		{
			_productInfra = productInfra;
		}
		public Product AddProduct(Product newProduct)
		{
			return _productInfra.AddProduct(newProduct);
		}

		public IEnumerable<Product> GetProducts()
		{
			return _productInfra.GetProducts();
		}
	}
}
