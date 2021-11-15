using Microsoft.EntityFrameworkCore;
using Api.Domain.Entities;
using Api.Data.Mapping;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    
    {
        public DbSet<UserEntities> User {get;set;}

        public MyContext (DbContextOptions<MyContext>options):base (options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserEntities>(new UserMap().Configure);
}
        
    }
}