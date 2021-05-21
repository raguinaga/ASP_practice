namespace EditProduct
{
    public record ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SellPrice { get; set; }
    }
}