using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;

namespace NoteShop.BLL.Business_Logic
{
    public class Filters
    {
        private readonly IUnitOfWork data;

        public Filters(IUnitOfWork data) => this.data = data;

        public IEnumerable<Product> GetProductsCategory(ProductType type) => data.Products.Find(x => x.ProductType == type);
    }
}
