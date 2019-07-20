﻿using mvc_entity.Domain;
using mvc_entity.Mapping;
using System.Data.Entity;

namespace mvc_entity.Context
{
    public class BookStoreDataContext : DbContext
    {
        public BookStoreDataContext() : base("BookStoreConnectionString")
        {

        }

        public DbSet<Autor> Autores {get; set;}
        public DbSet<Categoria> Categorias {get; set;}
        public DbSet<Livro> Livros {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new LivroMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
        }
    }
}