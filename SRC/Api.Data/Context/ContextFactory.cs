using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usando para criar as Migrações
            var conectionString = "Serve= localhost;Port=3306;Uid=root;Database=dbAPI;Pwd=joe48184818";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(conectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}