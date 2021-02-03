using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class LikesRepository : IRepository<Cart>
    {
        private NoteShopContext context;

        public LikesRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Cart item) => context.Likes.Add(item);

        public IEnumerable<Cart> Find(Func<Cart, bool> predicate) => context.Likes.Where(predicate).ToList();

        public Cart Get(int id) => context.Likes.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Cart> GetAll() => context.Likes.ToList();

        public void Remove(int id) => context.Likes.Remove(Get(id));

        public void Update(Cart item) => context.Likes.Update(item);
    }
}
