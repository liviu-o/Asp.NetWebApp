using Microsoft.EntityFrameworkCore;

namespace Asp.NetEmpty.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        IEnumerable<Category> ICategoryRepository.AllCategories => 
        _appDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}