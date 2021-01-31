using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteShop.DAL.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private NoteShopContext context;

        public OrderRepository(NoteShopContext context)
        {
            this.context = context;
        }

        public void Create(Order item) => context.Orders.Add(item);

        public IEnumerable<Order> Find(Func<Order, bool> predicate) => context.Orders.Where(predicate).ToList();

        public Order Get(int id) => context.Orders.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Order> GetAll() => context.Orders.ToList();

        public void Remove(int id) => context.Orders.Remove(Get(id));

        public void Update(Order item) => context.Orders.Update(item);
    }
}
