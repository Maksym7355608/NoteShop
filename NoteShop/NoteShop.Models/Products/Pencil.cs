namespace NoteShop.Models
{
    class Pencil : Product
    {
        public Hardness MyProperty { get; set; }
    }

    public enum Hardness : uint
    {
        B,
        HB,
        F,
        H,
        HH
    }
}
