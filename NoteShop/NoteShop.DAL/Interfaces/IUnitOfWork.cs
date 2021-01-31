using NoteShop.Models;

namespace NoteShop.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> Products { get; }
        IRepository<Paper> Papers { get; }
        IRepository<Notebook> Notebooks { get; }
        IRepository<Diary> Diaries { get; }
        IRepository<WritingTool> WritingTools { get; }
        IRepository<Pen> Pens { get; }
        IRepository<Pencil> Pencils { get; }
        IRepository<Cart> Carts { get; }
        IRepository<Likes> Likes { get; }
        IRepository<Order> Orders { get; }
    }
}
