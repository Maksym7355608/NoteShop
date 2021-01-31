using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class NotebookRepository : IRepository<Notebook>
    {
        private NoteShopContext context;

        public NotebookRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Notebook item) => context.Notebooks.Add(item);

        public IEnumerable<Notebook> Find(Func<Notebook, bool> predicate) => context.Notebooks.Where(predicate).ToList();

        public Notebook Get(int id) => context.Notebooks.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Notebook> GetAll() => context.Notebooks.ToList();

        public void Remove(int id) => context.Notebooks.Remove(Get(id));

        public void Update(Notebook item) => context.Notebooks.Update(item);
    }
}
