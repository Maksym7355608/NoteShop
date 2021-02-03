namespace NoteShop.Models
{
    public class Pen : Product
    {
        public Color Color { get; set; }
        public float Thickness { get; set; }
    }

    public enum Color : uint
    {
        Blue,
        Black,
        Green,
        Red
    }
}
