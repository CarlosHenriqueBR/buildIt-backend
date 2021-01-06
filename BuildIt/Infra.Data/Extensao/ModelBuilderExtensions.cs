using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Extensao
{
    internal static class ModelBuilderExtensions
    {
        public static void RemoveCascadeDeleteConvention(this ModelBuilder modelBuilder)
        {
            var imutableEntities = modelBuilder.Model.GetEntityTypes()
                .Where(e => !e.IsOwned())
                .SelectMany(e => e.GetForeignKeys());

            foreach (var relationship in imutableEntities)
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}