using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=ToDoListContext")
        {

        }
        public DbSet<Task> Tasks { get; set; }
    }
}