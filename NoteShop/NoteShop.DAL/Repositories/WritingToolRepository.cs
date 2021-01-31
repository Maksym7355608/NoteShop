using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class WritingToolRepository : IRepository<WritingTool>
    {
        private NoteShopContext context;

        public WritingToolRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(WritingTool item) => context.WritingTools.Add(item);

        public IEnumerable<WritingTool> Find(Func<WritingTool, bool> predicate) => context.WritingTools.Where(predicate).ToList();

        public WritingTool Get(int id) => context.WritingTools.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<WritingTool> GetAll() => context.WritingTools.ToList();

        public void Remove(int id) => context.WritingTools.Remove(Get(id));

        public void Update(WritingTool item) => context.WritingTools.Update(item);
    }
}
