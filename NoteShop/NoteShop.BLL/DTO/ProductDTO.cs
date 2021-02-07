using System;

namespace NoteShop.BLL.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public float Price { get; set; }
        public DateTime Time { get; set; }
        public bool IsActive { get; set; }
    }
}
