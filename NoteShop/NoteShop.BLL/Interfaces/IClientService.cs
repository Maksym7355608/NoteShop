using NoteShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteShop.BLL.Interfaces
{
    public interface IClientService
    {
        IOrderService OrderService { get; }
        ICartService CartService { get; }
        IEnumerable<Product> GetAll();
        Product Get(int id);
        IEnumerable<Product> GetProductsWithDiscount();
        IEnumerable<Product> GetProductsByCategory(ProductType type);
    }

    public interface IOrderService
    {
        void MakeOrder(Order order);
        IEnumerable<Product> GetOrderProducts();
    }

    public interface ICartService
    {
        void AddToCart(Product item);
        void RemoveFromCart(int id);
        float CalculateSum();
        IEnumerable<Product> GetCartProducts();
    }
}
