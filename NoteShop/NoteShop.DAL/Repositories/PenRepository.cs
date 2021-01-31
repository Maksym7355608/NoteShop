using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class PenRepository : IRepository<Pen>
    {
        private NoteShopContext context;

        public PenRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Pen item) => context.Pens.Add(item);

        public IEnumerable<Pen> Find(Func<Pen, bool> predicate) => context.Pens.Where(predicate).ToList();

        public Pen Get(int id) => context.Pens.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Pen> GetAll() => context.Pens.ToList();

        public void Remove(int id) => context.Pens.Remove(Get(id));

        public void Update(Pen item) => context.Pens.Update(item);
    }
}
