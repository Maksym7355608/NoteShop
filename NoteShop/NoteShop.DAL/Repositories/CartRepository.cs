using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class CartRepository : IRepository<Cart>
    {
        private NoteShopContext context;

        public CartRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Cart item) => context.Carts.Add(item);

        public IEnumerable<Cart> Find(Func<Cart, bool> predicate) => context.Carts.Where(predicate).ToList();

        public Cart Get(int id) => context.Carts.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Cart> GetAll() => context.Carts.ToList();

        public void Remove(int id) => context.Carts.Remove(Get(id));

        public void Update(Cart item) => context.Carts.Update(item);
    }
}
