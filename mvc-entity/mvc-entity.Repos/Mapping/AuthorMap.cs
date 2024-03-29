﻿using mvc_entity.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace mvc_entity.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("Autor");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(60).IsRequired();

            HasMany(x => x.Livros).WithMany(x => x.Autores).Map(x => x.ToTable("LivroAutor"));

        }
    }
}