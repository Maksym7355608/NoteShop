using System.Collections.Generic;

namespace NoteShop.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public IEnumerable<ProductsInOrder> Products { get; set; }
        public float Sum { get; set; }
    }
}
