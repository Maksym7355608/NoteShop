using System.Collections.Generic;

namespace NoteShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int? CartId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public float Sum { get; set; }

    }
}
