using NoteShop.Models;

namespace NoteShop.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> Products { get; }
        IRepository<Notebook> Notebooks { get; }
        IRepository<Diary> Diaries { get; }
        IRepository<Pen> Pens { get; }
        IRepository<Pencil> Pencils { get; }
        IRepository<Cart> Carts { get; }
        IRepository<Cart> Likes { get; }
        IRepository<Order> Orders { get; }
    }
}
