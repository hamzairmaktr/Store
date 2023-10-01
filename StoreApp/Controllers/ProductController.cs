using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _repositoryContext;

        public ProductController(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IActionResult Index()
        {
            var model = _repositoryContext.Products.ToList();
            return View(model);
        }
        public IActionResult Get(int id)
        {
            var res = _repositoryContext.Products.SingleOrDefault(p => p.Id.Equals(id));
            return View(res);
        }
    }
}
