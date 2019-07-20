using mvc_entity.Filters;
using mvc_entity.Repos.Repositories.Contracts;
using mvc_entity.Repos.Repositories;
using System.Web.Mvc;
using mvc_entity.Domain;

namespace mvc_entity.Controllers
{
    [RoutePrefix("authors")]
    [LogActionFilter()]
    public class AuthorController : Controller
    {
        private IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository repository)
        {
            _authorRepository = repository;
        }

        [Route("list")]
        //[LogActionFilter()]
        public ActionResult Index()
        {
            var authors = _authorRepository.Get();

            return View(authors);
        }

        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Author author)
        {
            if (_authorRepository.Create(author))
                return RedirectToAction("Index");

            return View(author);
        }

        [Route("update/{id:int}")]
        public ActionResult Update(int id)
        {
            var author = _authorRepository.Get(id);
            return View(author);
        }

        [HttpPost]
        [Route("update/{id:int}")]
        public ActionResult Update(Author author)
        {
            if (_authorRepository.Update(author))
                return RedirectToAction("Index");

            return View(author);
        }

        [Route("delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            var author = _authorRepository.Get(id);

            return View(author);
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            if(_authorRepository.Delete(id))
                return RedirectToAction("Index");

            return View();
        }

       
    }
}