using mvc_entity.Domain;
using mvc_entity.Repos.Repositories;
using mvc_entity.Repos.Repositories.Contracts;
using mvc_entity.ViewModels;
using System.Web.Mvc;

namespace mvc_entity.Controllers
{
    [RoutePrefix("books")]
    public class BookController : Controller
    {
        private IBookRepository _bookRepository;
        private ICategoryRepository _categoriaRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoriaRepository = categoryRepository;
        }

        [Route("list")]
        public ActionResult Index()
        {
            var books = _bookRepository.Get();

            return View(books);
        }

        [Route("create")]
        public ActionResult Create()
        {
            var categorias = _categoriaRepository.Get();
            var model = new EditorBookViewModel {
                Nome = "",
                ISBN = "",
                CategoriaId = 0,
                CategoriaOpcoes = new SelectList(categorias, "Id", "Nome")
            };
            return View(model);
        }

        [HttpPost]
        [Route("list")]
        public ActionResult Create(Book book)
        {
            if (_bookRepository.Create(book))
                return RedirectToAction("Index");

            return View(book);
        }

        [Route("update/{id:int}")]
        public ActionResult Update(int id)
        {
            var book = _bookRepository.Get(id);
            return View(book);
        }

        [HttpPost]
        [Route("update/{id:int}")]
        public ActionResult Update(Book book)
        {
            if (_bookRepository.Update(book))
                return RedirectToAction("Index");

            return View(book);
        }
        
        [Route("delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            var book = _bookRepository.Get(id);
            return View(book);
        }
        [HttpPost]
        [Route("delete/{id:int}")]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            if (_bookRepository.Delete(id))
                return RedirectToAction("Index");
            
            return View();
        }
    }
}