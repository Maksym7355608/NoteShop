using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.DAL.Repositories;
using NoteShop.Models;

namespace NoteShop.Root
{
    public static class ModuleService
    {
        public static void DependencyInjections(IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<NoteShopContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultLocalConnection")));
            service.AddScoped<NoteShopContext>();

            service.AddScoped<IRepository<Product>, ProductRepository>();
            service.AddScoped<IRepository<Paper>, PaperRepository>();
            service.AddScoped<IRepository<WritingTool>, WritingToolRepository>();
            service.AddScoped<IRepository<Notebook>, NotebookRepository>();
            service.AddScoped<IRepository<Diary>, DiaryRepository>();
            service.AddScoped<IRepository<Pen>, PenRepository>();
            service.AddScoped<IRepository<Pencil>, PencilRepository>();
            service.AddScoped<IRepository<Cart>, CartRepository>();
            service.AddScoped<IRepository<Likes>, LikesRepository>();
            service.AddScoped<IRepository<Order>, OrderRepository>();

            service.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
