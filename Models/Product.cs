namespace OnlineShopAspNet.Models
{
	public class Product
	{
		public int ProductId { get; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public decimal ProductCost { get; set; }

		public Product(string productName, string productDescription, decimal productCost)
		{
			ProductName = productName;
			ProductDescription = productDescription;
			ProductCost = productCost;
		}
		public override string ToString()
		{
			return $"{ProductName}: {ProductDescription} - {ProductCost}";
		}
	}
}
