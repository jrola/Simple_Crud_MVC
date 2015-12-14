using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SimpleCRUD_MVC.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class PersonContext : DbContext 
    {
        public DbSet<Person> people { get; set; }
    }
}