namespace NoteShop.Models
{
    public class Notebook : Product
    {
        public int PageCount { get; set; }
        public Format Size { get; set; }
        public Murkup Murkup { get; set; }
    }

    public enum Format : uint
    {
        A4,
        A5,
        A6
    }

    public enum Murkup : uint
    {
        Square,
        Inline,
        Oblique
    }
}
