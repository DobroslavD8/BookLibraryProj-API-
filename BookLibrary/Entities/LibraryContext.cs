namespace BookLibrary.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BorrowBook> BorrowBooks { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorrowBook>()
                .Property(e => e.BookID)
                .IsFixedLength();

            modelBuilder.Entity<BorrowBook>()
                .Property(e => e.UserID)
                .IsFixedLength();

            modelBuilder.Entity<Reader>()
                .HasOptional(e => e.BorrowBook)
                .WithRequired(e => e.Reader);
        }
    }
}
