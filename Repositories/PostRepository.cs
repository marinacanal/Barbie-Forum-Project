using barbieProject.Models;
using Microsoft.EntityFrameworkCore;

namespace barbieProject.Repositories
{
    public class PostRepository : Repository<Post>
    {   
        private readonly DbContext _context;
        public PostRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}