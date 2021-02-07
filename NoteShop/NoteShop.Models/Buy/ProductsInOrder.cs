namespace NoteShop.Models
{
    public class ProductsInOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? OrderId { get; set; }
        public int? CartId { get; set; }

    }
}
