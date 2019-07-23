using mvc_entity.Domain;
using mvc_entity.Repos.Repositories.Contracts;
using mvc_entity.ViewModels;
using System.Web.Mvc;

namespace mvc_entity.Controllers
{
    [RoutePrefix("categories")]
    public class CategoryController : Controller
    {
        private ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: Category
        [Route("list")]
        public ActionResult Index()
        {
            var categories = _categoryRepository.Get();

            return View(categories);
        }
        [Route("create")]
        public ActionResult Create(EditorCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ErrorMessage", "Modelo inválido");

                return View(model);
            }

            Category category = new Category {
                Nome = model.Nome
            };

            return View(category);
        }
        [HttpPost]
        [Route("create")]
        public ActionResult Create(Category category)
        {
            if (_categoryRepository.Create(category))
            {
                return RedirectToAction("Index");
            }

            return View(category);
        }
        [Route("update/{id:int}")]
        public ActionResult Update(int id)
        {
            var category = _categoryRepository.Get(id);
            EditorCategoryViewModel model = new EditorCategoryViewModel {
                Nome = category.Nome
            };

            return View(model);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public ActionResult Update(Category category)
        {
            if (_categoryRepository.Update(category))
            {
                return RedirectToAction("Index");
            };

            return View(category);
        }
        [Route("delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            var category = _categoryRepository.Get(id);

            return View(category);
        }
        [HttpPost]
        [Route("delete/{id:int}")]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            if (_categoryRepository.Delete(id))
            {
                return RedirectToAction("Index");
            };
            return View();
        }


    }
}