using NoteShop.DAL.EF;
using NoteShop.DAL.Interfaces;
using NoteShop.Models;

namespace NoteShop.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProductRepository productRepository;
        private PaperRepository paperRepository;
        private NotebookRepository notebookRepository;
        private DiaryRepository diaryRepository;
        private WritingToolRepository toolRepository;
        private PenRepository penRepository;
        private PencilRepository pencilRepository;
        private CartRepository cartRepository;
        private LikesRepository likesRepository;
        private OrderRepository orderRepository;

        private NoteShopContext context;

        public UnitOfWork(NoteShopContext context)
        {
            this.context = context;
        }

        public IRepository<Product> Products
        {
            get
            {
                return productRepository ??= new ProductRepository(context);
            }
        }


        public IRepository<Paper> Papers
        {
            get
            {
                return paperRepository ??= new PaperRepository(context);
            }
        }

        public IRepository<Notebook> Notebooks
        {
            get
            {
                return notebookRepository ??= new NotebookRepository(context);
            }
        }

        public IRepository<Diary> Diaries
        {
            get
            {
                return diaryRepository ??= new DiaryRepository(context);
            }
        }

        public IRepository<WritingTool> WritingTools
        {
            get
            {
                return toolRepository ??= new WritingToolRepository(context);
            }
        }

        public IRepository<Pen> Pens
        {
            get
            {
                return penRepository ??= new PenRepository(context);
            }
        }

        public IRepository<Pencil> Pencils
        {
            get
            {
                return pencilRepository ??= new PencilRepository(context);
            }
        }

        public IRepository<Cart> Carts
        {
            get
            {
                return cartRepository ??= new CartRepository(context);
            }
        }

        public IRepository<Likes> Likes
        {
            get
            {
                return likesRepository ??= new LikesRepository(context);
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                return orderRepository ??= new OrderRepository(context);
            }
        }
    }
}
