using DanielCunha.Toolkit.PostgreSQL.SnakeCase.Extensions;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    public static class ModelBuilderExtensions
    {
        public static void ApplySnakeCase(this ModelBuilder modelBuilder)
        {
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