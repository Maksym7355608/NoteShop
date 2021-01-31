using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class LikesRepository : IRepository<Likes>
    {
        private NoteShopContext context;

        public LikesRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Likes item) => context.Likes.Add(item);

        public IEnumerable<Likes> Find(Func<Likes, bool> predicate) => context.Likes.Where(predicate).ToList();

        public Likes Get(int id) => context.Likes.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Likes> GetAll() => context.Likes.ToList();

        public void Remove(int id) => context.Likes.Remove(Get(id));

        public void Update(Likes item) => context.Likes.Update(item);
    }
}
