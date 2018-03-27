using Microsoft.EntityFrameworkCore;
using System;

namespace Common
{
    public class ModelContext : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //连接字符串。
        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Id2 { get; set; }
        public string Name { get; set; }
    }
}
