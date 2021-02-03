namespace NoteShop.Models
{
    public class Diary : Product
    {
        public Cover StyleCover { get; set; }
    }

    public enum Cover : uint
    {
        Hard,
        Soft,
        Leather
    }
}
