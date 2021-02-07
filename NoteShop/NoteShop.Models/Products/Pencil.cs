namespace NoteShop.Models
{
    public class Pencil : Product
    {
        public Hardness Hardness { get; set; }
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
