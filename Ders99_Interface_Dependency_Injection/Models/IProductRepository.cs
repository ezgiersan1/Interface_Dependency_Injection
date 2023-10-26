namespace Ders99_Interface_Dependency_Injection.Models
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetAllProducts(); //ürün listesi

		Product GetProduct(int id); //detay 

		Product Delete(int id); //sil

		Product Add(Product newProduct); //ekleme

		Product Update(Product updateProduct); // güncelle

	}
}
