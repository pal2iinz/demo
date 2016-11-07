namespace demo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbcontext : DbContext
    {
        public dbcontext()
            : base("name=dbcontext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<demo.Models.Book> Books { get; set; }
    }
}
