using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HrmsDatabaseContext dbContext;
        public DbFactory(HrmsDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public HrmsDatabaseContext Get()
        {
            return dbContext ?? (dbContext = new HrmsDatabaseContext(new Microsoft.EntityFrameworkCore.DbContextOptions<HrmsDatabaseContext>()));
        }
    }
}