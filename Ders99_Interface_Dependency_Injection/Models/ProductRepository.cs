namespace Ders99_Interface_Dependency_Injection.Models
{
	public class ProductRepository : IProductRepository
	{
		private List<Product> _productList;

		public ProductRepository()
		{
			_productList = new List<Product>()
			{
				new Product() { ID=1,Adi="Televizyon",Fiyat=20000,Kategori="Elektronik" },
				new Product() { ID=2,Adi="Cep Telefonu",Fiyat=20000,Kategori="Elektronik" },
				new Product() { ID=3,Adi="Masa",Fiyat=20000,Kategori="Ev Eşyası" },
				new Product() { ID=4,Adi="BuzDolabı",Fiyat=20000,Kategori="Beyaz Eşya" },
				new Product() { ID=5,Adi="Çamaşır Makinesi",Fiyat=20000,Kategori="Beyaz Eşya" }
			};
		}
		public IEnumerable<Product> GetAllProducts()
		{
			return _productList.ToList();
		}

		public Product GetProduct(int id)
		{
			return _productList.FirstOrDefault(p => p.ID == id);
		}
		public Product Add(Product newProduct)
		{
			_productList.Add(newProduct);
			return newProduct;
		}

		public Product Delete(int id)
		{
			Product productDelete = _productList.FirstOrDefault(p => p.ID == id); //eski kayda ulaştım
			if (productDelete != null) 
			{
				_productList.Remove(productDelete);
			}
			return productDelete;
		}

		public Product Update(Product updateProduct)
		{
			throw new NotImplementedException();
		}
	}
}
