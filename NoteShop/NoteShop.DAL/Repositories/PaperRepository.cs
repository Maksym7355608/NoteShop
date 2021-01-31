using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class PaperRepository : IRepository<Paper>
    {
        private NoteShopContext context;

        public PaperRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Paper item) => context.Papers.Add(item);

        public IEnumerable<Paper> Find(Func<Paper, bool> predicate) => context.Papers.Where(predicate).ToList();

        public Paper Get(int id) => context.Papers.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Paper> GetAll() => context.Papers.ToList();

        public void Remove(int id) => context.Papers.Remove(Get(id));

        public void Update(Paper item) => context.Papers.Update(item);
    }
}
