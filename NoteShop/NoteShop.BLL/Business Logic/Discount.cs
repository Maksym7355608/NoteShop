using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NoteShop.Models;
using NoteShop.BLL.DTO;
using NoteShop.DAL.Interfaces;
using System.Threading.Tasks;
using System.Linq;

namespace NoteShop.BLL.Business_Logic
{
    public class Discount
    {
        private readonly int percent;
        private readonly float disc;
        private IEnumerable<ProductDTO> products;
        private const string PATH = @"wwwroot/json/discount.json";

        public Discount() { }

        public Discount(int percent)
        {
            this.percent = percent;
        }

        public Discount(float disc)
        {
            this.disc = disc;
        }

        public IEnumerable<Product> GetDiscoutnsProducts(IUnitOfWork data)
        {
            var dtos = GetDiscoutnsProductsDTO().Result;

            foreach (var item in dtos)
            {
                Product product = data.Products.Get(item.ProductId);
                product.Price = item.Price;
                yield return product;
            }
            yield return null;
        }

        private async Task<IEnumerable<ProductDTO>> GetDiscoutnsProductsDTO()
        {
            using FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read);

            try
            {
                products = await JsonSerializer.DeserializeAsync<List<ProductDTO>>(fs); 
            }
            catch
            { 
                products = new List<ProductDTO>(); 
            }


            foreach (var item in products)
                if (!CheckActive(item.Time))
                    products.ToList().Remove(item);

            return products;
        }

        public async void AddDiscount(Product product, DateTime time)
        {
            products = (List<ProductDTO>)GetDiscoutnsProductsDTO().Result;

            ProductDTO dto = new ProductDTO()
            {
                ProductId = product.Id,
                Price = GetDiscountPrice(product.Price),
                Time = time,
                IsActive = CheckActive(time)
            };

            products.ToList().Add(dto);

            using FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Write);
            await JsonSerializer.SerializeAsync(fs, products);
        }

        private bool CheckActive(DateTime time) => time > DateTime.Now;

        private float GetDiscountPrice(float start_price) => percent == default ? start_price - disc : start_price * (1 - percent);
    }
}
