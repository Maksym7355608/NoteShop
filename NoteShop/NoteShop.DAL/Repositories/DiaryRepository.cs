using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class DiaryRepository : IRepository<Diary>
    {
        private NoteShopContext context;

        public DiaryRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Diary item) => context.Diaries.Add(item);

        public IEnumerable<Diary> Find(Func<Diary, bool> predicate) => context.Diaries.Where(predicate).ToList();

        public Diary Get(int id) => context.Diaries.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Diary> GetAll() => context.Diaries.ToList();

        public void Remove(int id) => context.Diaries.Remove(Get(id));

        public void Update(Diary item) => context.Diaries.Update(item);
    }
}
