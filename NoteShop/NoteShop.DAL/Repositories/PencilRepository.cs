using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class PencilRepository : IRepository<Pencil>
    {
        private NoteShopContext context;

        public PencilRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Pencil item) => context.Pencils.Add(item);

        public IEnumerable<Pencil> Find(Func<Pencil, bool> predicate) => context.Pencils.Where(predicate).ToList();

        public Pencil Get(int id) => context.Pencils.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Pencil> GetAll() => context.Pencils.ToList();

        public void Remove(int id) => context.Pencils.Remove(Get(id));

        public void Update(Pencil item) => context.Pencils.Update(item);
    }
}
