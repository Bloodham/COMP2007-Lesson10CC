namespace COMP2007_S2016_Lesson10CC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodContext : DbContext
    {
        public FoodContext()
            : base("name=FoodConnection")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
