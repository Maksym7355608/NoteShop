namespace NoteShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public ProductType ProductType { get; set; }
    }

    public enum ProductType : uint
    {
        Notebook = 1,
        Diary,
        Pen,
        Pencil
    }

}
