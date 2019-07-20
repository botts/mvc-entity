using mvc_entity.Domain;
using System.Data.Entity.ModelConfiguration;

namespace mvc_entity.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Categoria");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(30).IsRequired();

            HasMany(x => x.Livros).WithRequired(x => x.Categoria);

        }
    }
}