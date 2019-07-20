using mvc_entity.Context;
using mvc_entity.Repos.Repositories;
using mvc_entity.Repos.Repositories.Contracts;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace mvc_entity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<BookStoreDataContext, BookStoreDataContext>();
            container.RegisterType<IAuthorRepository, AuthorRepository>();
            container.RegisterType<IBookRepository, BookRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}