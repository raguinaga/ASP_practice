namespace RazorPageLayout
{
    public class ProductDetails
    {
        public string Name { get; set; }
        public decimal SellPrice { get; set; }
        public int QtyInStock { get; set; }

        public ProductDetails(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.SellPrice = price;
            this.QtyInStock = quantity;
        }
    }
}