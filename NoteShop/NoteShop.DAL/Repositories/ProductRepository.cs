using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private NoteShopContext context;

        public ProductRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Product item) => context.Products.Add(item);

        public IEnumerable<Product> Find(Func<Product, bool> predicate) => context.Products.Where(predicate).ToList();

        public Product Get(int id) => context.Products.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Product> GetAll() => context.Products.ToList();

        public void Remove(int id) => context.Products.Remove(Get(id));

        public void Update(Product item) => context.Products.Update(item);
    }
}
