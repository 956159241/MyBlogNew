using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlogNew.Entity;

namespace MyBlogNew.Common
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyBlogNewEntities : DbContext
    {
        public MyBlogNewEntities()
            : base("name=myblognewEntities")
        {
        }
        public DbSet<theme> themes { get; set; }

        public DbSet<navigation> navigations { get; set; }

        public DbSet<diary> diaries { get; set; }
    }
}