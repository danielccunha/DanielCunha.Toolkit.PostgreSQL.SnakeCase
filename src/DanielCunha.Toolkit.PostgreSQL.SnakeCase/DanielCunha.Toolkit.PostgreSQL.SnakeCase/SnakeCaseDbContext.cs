using DanielCunha.Toolkit.PostgreSQL.SnakeCase.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DanielCunha.Toolkit.PostgreSQL.SnakeCase
{
    public abstract class SnakeCaseDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Lower case all columns and tables (configuration for PostgreSQL)
            foreach(var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Replace table names
                entity.SetTableName(entity.GetTableName().ToSnakeCase());

                // Replace column names            
                foreach(var property in entity.GetProperties())
                    property.SetColumnName(property.GetColumnName().ToSnakeCase());

                foreach(var key in entity.GetKeys())
                    key.SetName(key.GetName().ToSnakeCase());

                foreach(var key in entity.GetForeignKeys())
                    key.SetConstraintName(key.GetConstraintName().ToSnakeCase());

                foreach(var index in entity.GetIndexes())
                    index.SetName(index.GetName().ToSnakeCase());
            }
        }
    }
}