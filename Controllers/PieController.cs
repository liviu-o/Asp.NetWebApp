using Asp.NetEmpty.Models;
using Asp.NetEmpty.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetEmpty.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List(string category)
        {
            //Without View Model
            // ViewBag.CurrentCategory = "Cheese cakes";
            // return View(_pieRepository.AllPies);

            //With ViewModel

            IEnumerable<Pie> pies;
            string? currentCategory;

            if(string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else 
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.Category.CategoryName == category)
                .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
         return View(new PieListViewModel(pies, currentCategory));
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if(pie == null) 
            {
                return NotFound();
            }
            return View(pie);
        }

         public IActionResult Search()
        {
            return View();
        }
    }
}