using day16.Models;
using Microsoft.EntityFrameworkCore;

namespace day16.Context;

public class ApplicationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-P9GD2V1\\SQLEXPRESS;Database=day16;Trusted_Connection=True;Encrypt=False;trustservercertificate=true;");
    }


    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Author { get; set; }

}
