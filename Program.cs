List<Product> products = new()
{
  new Product("Tv", 900),
  new Product("Mouse", 50),
  new Product("Tablet", 350.50),
  new Product("HD Case", 80.90)
};

static bool ProductsWithPriceGreaterThanOrEqualTo100(Product product)
{
  return product.Price >= 100;
}

products.RemoveAll(ProductsWithPriceGreaterThanOrEqualTo100);

foreach(var product in products)
{
  System.Console.WriteLine($"{product.Name} - {product.Price:F2}");
}